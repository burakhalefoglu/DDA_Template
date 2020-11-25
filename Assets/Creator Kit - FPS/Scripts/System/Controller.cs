using System;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

[System.Serializable]
public class AmmoInventoryEntry
{
    [AmmoType]
    public int ammoType;
    public int amount = 0;
}

public class Controller : MonoBehaviour
{
    //Urg that's ugly, maybe find a better way
    public static Controller Instance { get; protected set; }

    public Camera MainCamera;
    public Camera WeaponCamera;
    
    public Transform CameraPosition;
    public Transform WeaponPosition;
    
    public Weapon[] startingWeapons;

    //this is only use at start, allow to grant ammo in the inspector. m_AmmoInventory is used during gameplay
    public AmmoInventoryEntry[] startingAmmo;

    [Header("Control Settings")]
    //public float MouseSensitivity = 0.00000000001f;
    public float PlayerSpeed = 4.0f;
    public float RunningSpeed = 5.0f;
    public float JumpSpeed = 5.0f;

    [Header("Audio")]
    public RandomPlayer FootstepPlayer;
    public AudioClip JumpingAudioCLip;
    public AudioClip LandingAudioClip;
    
    float m_VerticalSpeed = 0.0f;
    int m_CurrentWeapon;
    
    float m_VerticalAngle, m_HorizontalAngle;
    public float Speed { get; private set; } = 0.0f;

    public bool LockControl { get; set; }

    public bool Grounded => m_Grounded;

    CharacterController m_CharacterController;

    bool m_Grounded;
    float m_GroundedTimer;
    float m_SpeedAtJump = 0.0f;

    List<Weapon> m_Weapons = new List<Weapon>();
    Dictionary<int, int> m_AmmoInventory = new Dictionary<int, int>();
    float TotalAttackCount;

    void Awake()
    {
        Instance = this;
    }
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        m_Grounded = true;
        
        MainCamera.transform.SetParent(CameraPosition, false);
        MainCamera.transform.localPosition = Vector3.zero;
        MainCamera.transform.localRotation = Quaternion.identity;
        m_CharacterController = GetComponent<CharacterController>();

        for (int i = 0; i < startingWeapons.Length; ++i)
        {
            PickupWeapon(startingWeapons[i]);
        }

        for (int i = 0; i < startingAmmo.Length; ++i)
        {
            ChangeAmmo(startingAmmo[i].ammoType, startingAmmo[i].amount);
        }
        
        m_CurrentWeapon = -1;
        ChangeWeapon(0);

        for (int i = 0; i < startingAmmo.Length; ++i)
        {
            m_AmmoInventory[startingAmmo[i].ammoType] = startingAmmo[i].amount;
        }

        m_VerticalAngle = 0.0f;
        m_HorizontalAngle = transform.localEulerAngles.y;
    }

    bool Isjump=false;
    float footsteptime=0.3f;
    void Update()
    {

        if (transform.hasChanged)
        {
            footsteptime -= Time.deltaTime;
            transform.hasChanged = false;

        }
        else
        {
            footsteptime = 0.5f;
        }

        if (footsteptime <= 0)
        {
            footsteptime = 0.5f;
            PlayFootstep();
        }

        bool wasGrounded = m_Grounded;
        bool loosedGrounding = false;

        

        //we define our own grounded and not use the Character controller one as the character controller can flicker
        //between grounded/not grounded on small step and the like. So we actually make the controller "not grounded" only
        //if the character controller reported not being grounded for at least .5 second;
        if (!m_CharacterController.isGrounded)
        {
            if (m_Grounded)
            {
                m_GroundedTimer += Time.deltaTime;
                if (m_GroundedTimer >= 0.5f)
                {
                    loosedGrounding = true;
                    m_Grounded = false;
                }
            }
        }
        else
        {
            m_GroundedTimer = 0.0f;
            m_Grounded = true;

        }

        Speed = 0;
        Vector3 move = Vector3.zero;
        if (!LockControl)
        {
            // Jump (we do it first as 
            if (m_Grounded && Isjump)
            {
                Isjump = false;
                m_VerticalSpeed = JumpSpeed;
                m_Grounded = false;
                loosedGrounding = true;
                FootstepPlayer.PlayClip(JumpingAudioCLip, 0.8f,1.1f);
            }

            bool running = true;/*m_Weapons[m_CurrentWeapon].CurrentState == Weapon.WeaponState.Idle && Input.GetButton("Run");*/
            float actualSpeed = running ? RunningSpeed : PlayerSpeed;

            if (loosedGrounding)
            {
                m_SpeedAtJump = actualSpeed;
            }

            // Move around with WASD
            move = new Vector3(SimpleInput.GetAxis("Horizontal"), 0, SimpleInput.GetAxisRaw("Vertical"));

            if (move.sqrMagnitude > 1.0f)
                move.Normalize();

            float usedSpeed = m_Grounded ? actualSpeed : m_SpeedAtJump;
            
            move =move * usedSpeed * Time.deltaTime;
            
            move = transform.TransformDirection(move);
            m_CharacterController.Move(move);

           

            Speed = move.magnitude / (PlayerSpeed * Time.deltaTime);

          
            
            //Key input to change weapon

            for (int i = 0; i < 10; ++i)
            {
                if (Input.GetKeyDown(KeyCode.Alpha0 + i))
                {
                    int num = 0;
                    if (i == 0)
                        num = 10;
                    else
                        num = i - 1;

                    if (num < m_Weapons.Count)
                    {
                        ChangeWeapon(num);
                    }
                }
            }
        }

        // Fall down / gravity
        m_VerticalSpeed = m_VerticalSpeed - 10.0f * Time.deltaTime;
        if (m_VerticalSpeed < -10.0f)
            m_VerticalSpeed = -10.0f; // max fall speed
        var verticalMove = new Vector3(0, m_VerticalSpeed * Time.deltaTime, 0);
        var flag = m_CharacterController.Move(verticalMove);
        if ((flag & CollisionFlags.Below) != 0)
            m_VerticalSpeed = 0;

        if (!wasGrounded && m_Grounded)
        {
            FootstepPlayer.PlayClip(LandingAudioClip, 0.8f,1.1f);
        }
    }


    void PickupWeapon(Weapon prefab)
    {
        //TODO : maybe find a better way than comparing name...
        if (m_Weapons.Exists(weapon => weapon.name == prefab.name))
        {//if we already have that weapon, grant a clip size of the ammo type instead
            ChangeAmmo(prefab.ammoType, prefab.clipSize);
        }
        else
        {
            var w = Instantiate(prefab, WeaponPosition, false);
            w.name = prefab.name;
            w.transform.localPosition = Vector3.zero;
            w.transform.localRotation = Quaternion.identity;
            w.gameObject.SetActive(false);
            
            w.PickedUp(this);
            
            m_Weapons.Add(w);
        }
    }

    void ChangeWeapon(int number)
    {
        if (m_CurrentWeapon != -1)
        {
            m_Weapons[m_CurrentWeapon].PutAway();
            m_Weapons[m_CurrentWeapon].gameObject.SetActive(false);
        }

        m_CurrentWeapon = number;

        if (m_CurrentWeapon < 0)
            m_CurrentWeapon = m_Weapons.Count - 1;
        else if (m_CurrentWeapon >= m_Weapons.Count)
            m_CurrentWeapon = 0;
        
        m_Weapons[m_CurrentWeapon].gameObject.SetActive(true);
        m_Weapons[m_CurrentWeapon].Selected();
    }

    public int GetAmmo(int ammoType)
    {
        int value = 0;
        m_AmmoInventory.TryGetValue(ammoType, out value);

        return value;
    }

    public void ChangeAmmo(int ammoType, int amount)
    {
        if (!m_AmmoInventory.ContainsKey(ammoType))
            m_AmmoInventory[ammoType] = 0;

        var previous = m_AmmoInventory[ammoType];
        m_AmmoInventory[ammoType] = Mathf.Clamp(m_AmmoInventory[ammoType] + amount, 0, 999);

        if (m_Weapons[m_CurrentWeapon].ammoType == ammoType)
        {
            if (previous == 0 && amount > 0)
            {//we just grabbed ammo for a weapon that add non left, so it's disabled right now. Reselect it.
                m_Weapons[m_CurrentWeapon].Selected();
            }
            
            //WeaponInfoUI.Instance.UpdateAmmoAmount(GetAmmo(ammoType));
        }
    }

    public void PlayFootstep()
    {
        FootstepPlayer.PlayRandom();
    }

    public void changeWeaponRight()
    {
      ChangeWeapon(m_CurrentWeapon - 1);
    }

    public void changeWeaponLeft()
    {
        ChangeWeapon(m_CurrentWeapon + 1);
        TotalAttackCount++;
    }
    public float GetTotalAttack()
    {
        return TotalAttackCount;
    }
    public float GetTotalHit()
    {
        Weapon weapon =m_Weapons[m_CurrentWeapon].GetComponent<Weapon>();
        return weapon.GetTotalHit();
    }
    public void Jump()
    {
        Isjump = true;
    }
}
