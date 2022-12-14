//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.3
//     from Assets/PlayerInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Player Controls"",
            ""id"": ""bde5d81a-352f-4658-8ed2-00fee4f209b2"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""cbaf4f36-7220-4f68-8ac6-cdf6b1133e67"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Mouse Look"",
                    ""type"": ""Value"",
                    ""id"": ""7b088aad-4627-4b76-9898-b3d389712714"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""cab64a9a-6ae3-4d13-a994-d82bfc1690b9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""f375cff4-7e79-43c9-b2c9-423272a6bee4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""ccd8fcb9-4ebe-4dd3-923b-72a066af15b0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""Button"",
                    ""id"": ""742fc2ca-4708-4c96-a03d-9931cbb95139"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Reset Zoom"",
                    ""type"": ""Button"",
                    ""id"": ""68647131-b134-4aa3-939e-4d308755375d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Cursor Lock"",
                    ""type"": ""Button"",
                    ""id"": ""3d7fc4fe-5b6f-454f-8149-a5bfa80b288b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Cursor Unlock"",
                    ""type"": ""Button"",
                    ""id"": ""7ec33862-ea14-4a60-a643-7e1e27d31259"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Switch Camera"",
                    ""type"": ""Button"",
                    ""id"": ""52cbc9b7-fc33-419c-9f2e-56903fa6c928"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Cut Mode"",
                    ""type"": ""Button"",
                    ""id"": ""e053ade8-7dc2-4446-9e9f-ad9fe51e18b1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""e28801f6-27f5-448a-be0c-ab7b3a04ac84"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6ee5bfbd-fc99-4acf-9610-293527dae4fb"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4827a7db-bcab-4b8f-b732-b0d4f7a7e626"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""23f6eed8-936f-44f8-96cb-f579ba986daa"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8cc1f38f-759c-4584-8778-16705a096fa4"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7046e710-8ff6-46f5-ac2c-6b636412ce9d"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""02d20329-800f-443b-9506-da6e839731d7"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0b0d57fc-c7d1-41c2-bca2-1d48b9f6429d"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""662ecacd-a216-40b9-842d-eb805d41a88f"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dbdc1dcb-3600-477e-9094-57ba52f2092a"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2b1847c1-dd4c-42b2-82c5-88f7b943c497"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cursor Lock"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f87b41a7-7e13-4bed-8b9f-1e15ec3784b4"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cursor Unlock"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fd19f736-8f17-45c1-8e20-1310b0cc4655"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reset Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fea55b4f-8f8f-4024-a0d5-9dd382e14609"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b989fdd-3a46-4ff9-833f-856cabde7089"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""df0d3e0f-c82c-4250-846f-cbd5a28d8492"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2e5344e0-07dc-4d15-94f0-d20173a9065f"",
                    ""path"": ""<Keyboard>/alt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cut Mode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player Controls
        m_PlayerControls = asset.FindActionMap("Player Controls", throwIfNotFound: true);
        m_PlayerControls_Movement = m_PlayerControls.FindAction("Movement", throwIfNotFound: true);
        m_PlayerControls_MouseLook = m_PlayerControls.FindAction("Mouse Look", throwIfNotFound: true);
        m_PlayerControls_Jump = m_PlayerControls.FindAction("Jump", throwIfNotFound: true);
        m_PlayerControls_Crouch = m_PlayerControls.FindAction("Crouch", throwIfNotFound: true);
        m_PlayerControls_Sprint = m_PlayerControls.FindAction("Sprint", throwIfNotFound: true);
        m_PlayerControls_Zoom = m_PlayerControls.FindAction("Zoom", throwIfNotFound: true);
        m_PlayerControls_ResetZoom = m_PlayerControls.FindAction("Reset Zoom", throwIfNotFound: true);
        m_PlayerControls_CursorLock = m_PlayerControls.FindAction("Cursor Lock", throwIfNotFound: true);
        m_PlayerControls_CursorUnlock = m_PlayerControls.FindAction("Cursor Unlock", throwIfNotFound: true);
        m_PlayerControls_SwitchCamera = m_PlayerControls.FindAction("Switch Camera", throwIfNotFound: true);
        m_PlayerControls_CutMode = m_PlayerControls.FindAction("Cut Mode", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player Controls
    private readonly InputActionMap m_PlayerControls;
    private IPlayerControlsActions m_PlayerControlsActionsCallbackInterface;
    private readonly InputAction m_PlayerControls_Movement;
    private readonly InputAction m_PlayerControls_MouseLook;
    private readonly InputAction m_PlayerControls_Jump;
    private readonly InputAction m_PlayerControls_Crouch;
    private readonly InputAction m_PlayerControls_Sprint;
    private readonly InputAction m_PlayerControls_Zoom;
    private readonly InputAction m_PlayerControls_ResetZoom;
    private readonly InputAction m_PlayerControls_CursorLock;
    private readonly InputAction m_PlayerControls_CursorUnlock;
    private readonly InputAction m_PlayerControls_SwitchCamera;
    private readonly InputAction m_PlayerControls_CutMode;
    public struct PlayerControlsActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerControlsActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayerControls_Movement;
        public InputAction @MouseLook => m_Wrapper.m_PlayerControls_MouseLook;
        public InputAction @Jump => m_Wrapper.m_PlayerControls_Jump;
        public InputAction @Crouch => m_Wrapper.m_PlayerControls_Crouch;
        public InputAction @Sprint => m_Wrapper.m_PlayerControls_Sprint;
        public InputAction @Zoom => m_Wrapper.m_PlayerControls_Zoom;
        public InputAction @ResetZoom => m_Wrapper.m_PlayerControls_ResetZoom;
        public InputAction @CursorLock => m_Wrapper.m_PlayerControls_CursorLock;
        public InputAction @CursorUnlock => m_Wrapper.m_PlayerControls_CursorUnlock;
        public InputAction @SwitchCamera => m_Wrapper.m_PlayerControls_SwitchCamera;
        public InputAction @CutMode => m_Wrapper.m_PlayerControls_CutMode;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlsActions instance)
        {
            if (m_Wrapper.m_PlayerControlsActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMovement;
                @MouseLook.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMouseLook;
                @MouseLook.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMouseLook;
                @MouseLook.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMouseLook;
                @Jump.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                @Crouch.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnCrouch;
                @Sprint.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSprint;
                @Zoom.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnZoom;
                @Zoom.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnZoom;
                @Zoom.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnZoom;
                @ResetZoom.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnResetZoom;
                @ResetZoom.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnResetZoom;
                @ResetZoom.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnResetZoom;
                @CursorLock.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnCursorLock;
                @CursorLock.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnCursorLock;
                @CursorLock.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnCursorLock;
                @CursorUnlock.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnCursorUnlock;
                @CursorUnlock.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnCursorUnlock;
                @CursorUnlock.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnCursorUnlock;
                @SwitchCamera.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSwitchCamera;
                @SwitchCamera.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSwitchCamera;
                @SwitchCamera.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSwitchCamera;
                @CutMode.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnCutMode;
                @CutMode.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnCutMode;
                @CutMode.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnCutMode;
            }
            m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @MouseLook.started += instance.OnMouseLook;
                @MouseLook.performed += instance.OnMouseLook;
                @MouseLook.canceled += instance.OnMouseLook;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @Zoom.started += instance.OnZoom;
                @Zoom.performed += instance.OnZoom;
                @Zoom.canceled += instance.OnZoom;
                @ResetZoom.started += instance.OnResetZoom;
                @ResetZoom.performed += instance.OnResetZoom;
                @ResetZoom.canceled += instance.OnResetZoom;
                @CursorLock.started += instance.OnCursorLock;
                @CursorLock.performed += instance.OnCursorLock;
                @CursorLock.canceled += instance.OnCursorLock;
                @CursorUnlock.started += instance.OnCursorUnlock;
                @CursorUnlock.performed += instance.OnCursorUnlock;
                @CursorUnlock.canceled += instance.OnCursorUnlock;
                @SwitchCamera.started += instance.OnSwitchCamera;
                @SwitchCamera.performed += instance.OnSwitchCamera;
                @SwitchCamera.canceled += instance.OnSwitchCamera;
                @CutMode.started += instance.OnCutMode;
                @CutMode.performed += instance.OnCutMode;
                @CutMode.canceled += instance.OnCutMode;
            }
        }
    }
    public PlayerControlsActions @PlayerControls => new PlayerControlsActions(this);
    public interface IPlayerControlsActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnMouseLook(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
        void OnResetZoom(InputAction.CallbackContext context);
        void OnCursorLock(InputAction.CallbackContext context);
        void OnCursorUnlock(InputAction.CallbackContext context);
        void OnSwitchCamera(InputAction.CallbackContext context);
        void OnCutMode(InputAction.CallbackContext context);
    }
}