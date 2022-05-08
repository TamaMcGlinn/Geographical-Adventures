//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Input/Player Action.inputactions
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

public partial class @PlayerAction : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player Action"",
    ""maps"": [
        {
            ""name"": ""Player Controls"",
            ""id"": ""156a9099-89f5-4544-9c62-805c91ba812e"",
            ""actions"": [
                {
                    ""name"": ""Drop Package"",
                    ""type"": ""Button"",
                    ""id"": ""58cca24b-43c7-47cb-9159-c64941082333"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""8cee259e-1505-4fab-944c-c26d572003d1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Speed"",
                    ""type"": ""Button"",
                    ""id"": ""a32814bc-f2fa-41c7-84af-d5438b026f34"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Boost"",
                    ""type"": ""Button"",
                    ""id"": ""9a084ef6-3a9f-4eb5-b0f1-43b14cdfb9a8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ef28f26a-1044-4379-a9b0-c87e314dc6cc"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard QWERTY"",
                    ""action"": ""Drop Package"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4bcdae3e-9221-4050-8e56-202c21fe2abb"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Drop Package"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""03578778-66e6-43d8-825e-74af556afd83"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""eb47fda7-7456-47e9-b8f0-63263bb5b831"",
                    ""path"": ""2DVector(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""097cdf2a-158b-41fb-b023-01921142ebaf"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard QWERTY"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7932e6aa-683b-4ec8-bafd-4fd084f9c55a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard QWERTY"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""209170c4-ccfc-44c8-af52-5df09bf3044b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard QWERTY"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2cdfad30-015a-4ec0-9a5a-812908165284"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard QWERTY"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Change Speed"",
                    ""id"": ""39ad45e4-7a2f-4c0e-98fc-ae8bfcb77856"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Speed"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""8ae18f25-c48f-4f8f-b986-d1aeda4b43e0"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard QWERTY"",
                    ""action"": ""Speed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""d266d62f-8b11-41b4-af9c-14e1938c37c3"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard QWERTY"",
                    ""action"": ""Speed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Change Speed"",
                    ""id"": ""612f6780-0025-4490-81e5-b7fe715f53c0"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Speed"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e47dad47-1084-4ecd-807c-d1c99d50beba"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Speed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b6bb5a67-08de-43e1-997b-b3c5fc6370ea"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Speed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6f405b5b-97ba-4a6a-b0ab-23b3ce746042"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard QWERTY"",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""607932a8-e61e-4797-a397-fb51b91d5bd6"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Camera Controls"",
            ""id"": ""59d8a46a-bfc2-42aa-99e1-3f09c5076b83"",
            ""actions"": [
                {
                    ""name"": ""Top Camera View"",
                    ""type"": ""Button"",
                    ""id"": ""34f7c59f-17bf-4520-b616-6b09ea9d774b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Forward Camera View"",
                    ""type"": ""Button"",
                    ""id"": ""c90bfd6e-0c10-4e68-8bde-8179589f4166"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Backward Camera View"",
                    ""type"": ""Button"",
                    ""id"": ""597160a0-ece2-48da-ab79-69c9f9bfb7b4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ee5dadf7-a432-43f8-9551-9d4400cabf79"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard QWERTY"",
                    ""action"": ""Top Camera View"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b40c71c-366e-4714-93b1-61efc127d257"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Top Camera View"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6b8829f0-ee38-4e3e-b39d-ded425e2cd97"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Top Camera View"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d2dc09a4-f367-4728-8a50-fd25f4a9e48e"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard QWERTY"",
                    ""action"": ""Forward Camera View"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c489f49a-475e-489f-b210-cfcf58dc6f31"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Forward Camera View"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ff42c99b-a04c-45af-8062-eb61b6ccbabd"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard QWERTY"",
                    ""action"": ""Backward Camera View"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""47bb3ad5-3301-4095-af4b-0e6d7f0a9b84"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Backward Camera View"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI Controls"",
            ""id"": ""2199b0d5-45fe-4127-9c65-bca4b7e3f377"",
            ""actions"": [
                {
                    ""name"": ""Toggle Pause"",
                    ""type"": ""Button"",
                    ""id"": ""33498dff-970c-4b6c-a767-b8c1effeb10c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Toggle Map"",
                    ""type"": ""Button"",
                    ""id"": ""3571b66c-f446-4bec-978c-688a79fe2ad0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d30713d4-b893-4bd5-9e41-dedbcfa7f53d"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard QWERTY"",
                    ""action"": ""Toggle Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""525f9844-d904-4df7-b381-3e4bcd143a46"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard QWERTY"",
                    ""action"": ""Toggle Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dc306293-0abd-4bf6-a3f1-a93ff8b8194d"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Toggle Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ff482031-7566-41b6-b401-ba4dc5404f4c"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard QWERTY"",
                    ""action"": ""Toggle Map"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1f7a0fe4-d96a-47c6-883a-f5e5e70a133e"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Toggle Map"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Map Controls"",
            ""id"": ""93eacdd6-ff56-4002-a628-e7b51c13e474"",
            ""actions"": [
                {
                    ""name"": ""Map Zoom"",
                    ""type"": ""Value"",
                    ""id"": ""40114ba9-36f9-4376-b2c0-e23f3599e09d"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Turn"",
                    ""type"": ""Value"",
                    ""id"": ""6cb01646-3b35-4f8b-a5a3-b279917b72b1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e2db73c7-de1a-4c7b-8673-e61e758823e6"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": ""Normalize(min=-120,max=120)"",
                    ""groups"": ""Keyboard QWERTY"",
                    ""action"": ""Map Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""7f5e4652-f4f1-4ab5-896d-e6120217801b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Map Zoom"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""69169f2d-eadb-468e-8d6a-6660817e8712"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Map Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""08f7937c-4af6-406d-a593-f9b577f29331"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Map Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""One Modifier"",
                    ""id"": ""1db1cc2e-bfff-404a-a08e-c96b4cb37b9a"",
                    ""path"": ""OneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""ec3022dd-485d-488f-8964-f90a9ef36790"",
                    ""path"": ""<Mouse>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard QWERTY"",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""binding"",
                    ""id"": ""fe1f7344-3853-49a9-aa3d-bc8afed8d239"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard QWERTY"",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""90a4867d-43d3-43fa-9ba9-38f795e0d4fc"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=25,y=25),InvertVector2"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard QWERTY"",
            ""bindingGroup"": ""Keyboard QWERTY"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player Controls
        m_PlayerControls = asset.FindActionMap("Player Controls", throwIfNotFound: true);
        m_PlayerControls_DropPackage = m_PlayerControls.FindAction("Drop Package", throwIfNotFound: true);
        m_PlayerControls_Movement = m_PlayerControls.FindAction("Movement", throwIfNotFound: true);
        m_PlayerControls_Speed = m_PlayerControls.FindAction("Speed", throwIfNotFound: true);
        m_PlayerControls_Boost = m_PlayerControls.FindAction("Boost", throwIfNotFound: true);
        // Camera Controls
        m_CameraControls = asset.FindActionMap("Camera Controls", throwIfNotFound: true);
        m_CameraControls_TopCameraView = m_CameraControls.FindAction("Top Camera View", throwIfNotFound: true);
        m_CameraControls_ForwardCameraView = m_CameraControls.FindAction("Forward Camera View", throwIfNotFound: true);
        m_CameraControls_BackwardCameraView = m_CameraControls.FindAction("Backward Camera View", throwIfNotFound: true);
        // UI Controls
        m_UIControls = asset.FindActionMap("UI Controls", throwIfNotFound: true);
        m_UIControls_TogglePause = m_UIControls.FindAction("Toggle Pause", throwIfNotFound: true);
        m_UIControls_ToggleMap = m_UIControls.FindAction("Toggle Map", throwIfNotFound: true);
        // Map Controls
        m_MapControls = asset.FindActionMap("Map Controls", throwIfNotFound: true);
        m_MapControls_MapZoom = m_MapControls.FindAction("Map Zoom", throwIfNotFound: true);
        m_MapControls_Turn = m_MapControls.FindAction("Turn", throwIfNotFound: true);
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
    private readonly InputAction m_PlayerControls_DropPackage;
    private readonly InputAction m_PlayerControls_Movement;
    private readonly InputAction m_PlayerControls_Speed;
    private readonly InputAction m_PlayerControls_Boost;
    public struct PlayerControlsActions
    {
        private @PlayerAction m_Wrapper;
        public PlayerControlsActions(@PlayerAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @DropPackage => m_Wrapper.m_PlayerControls_DropPackage;
        public InputAction @Movement => m_Wrapper.m_PlayerControls_Movement;
        public InputAction @Speed => m_Wrapper.m_PlayerControls_Speed;
        public InputAction @Boost => m_Wrapper.m_PlayerControls_Boost;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlsActions instance)
        {
            if (m_Wrapper.m_PlayerControlsActionsCallbackInterface != null)
            {
                @DropPackage.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnDropPackage;
                @DropPackage.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnDropPackage;
                @DropPackage.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnDropPackage;
                @Movement.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMovement;
                @Speed.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSpeed;
                @Speed.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSpeed;
                @Speed.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSpeed;
                @Boost.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnBoost;
                @Boost.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnBoost;
                @Boost.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnBoost;
            }
            m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @DropPackage.started += instance.OnDropPackage;
                @DropPackage.performed += instance.OnDropPackage;
                @DropPackage.canceled += instance.OnDropPackage;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Speed.started += instance.OnSpeed;
                @Speed.performed += instance.OnSpeed;
                @Speed.canceled += instance.OnSpeed;
                @Boost.started += instance.OnBoost;
                @Boost.performed += instance.OnBoost;
                @Boost.canceled += instance.OnBoost;
            }
        }
    }
    public PlayerControlsActions @PlayerControls => new PlayerControlsActions(this);

    // Camera Controls
    private readonly InputActionMap m_CameraControls;
    private ICameraControlsActions m_CameraControlsActionsCallbackInterface;
    private readonly InputAction m_CameraControls_TopCameraView;
    private readonly InputAction m_CameraControls_ForwardCameraView;
    private readonly InputAction m_CameraControls_BackwardCameraView;
    public struct CameraControlsActions
    {
        private @PlayerAction m_Wrapper;
        public CameraControlsActions(@PlayerAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @TopCameraView => m_Wrapper.m_CameraControls_TopCameraView;
        public InputAction @ForwardCameraView => m_Wrapper.m_CameraControls_ForwardCameraView;
        public InputAction @BackwardCameraView => m_Wrapper.m_CameraControls_BackwardCameraView;
        public InputActionMap Get() { return m_Wrapper.m_CameraControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraControlsActions set) { return set.Get(); }
        public void SetCallbacks(ICameraControlsActions instance)
        {
            if (m_Wrapper.m_CameraControlsActionsCallbackInterface != null)
            {
                @TopCameraView.started -= m_Wrapper.m_CameraControlsActionsCallbackInterface.OnTopCameraView;
                @TopCameraView.performed -= m_Wrapper.m_CameraControlsActionsCallbackInterface.OnTopCameraView;
                @TopCameraView.canceled -= m_Wrapper.m_CameraControlsActionsCallbackInterface.OnTopCameraView;
                @ForwardCameraView.started -= m_Wrapper.m_CameraControlsActionsCallbackInterface.OnForwardCameraView;
                @ForwardCameraView.performed -= m_Wrapper.m_CameraControlsActionsCallbackInterface.OnForwardCameraView;
                @ForwardCameraView.canceled -= m_Wrapper.m_CameraControlsActionsCallbackInterface.OnForwardCameraView;
                @BackwardCameraView.started -= m_Wrapper.m_CameraControlsActionsCallbackInterface.OnBackwardCameraView;
                @BackwardCameraView.performed -= m_Wrapper.m_CameraControlsActionsCallbackInterface.OnBackwardCameraView;
                @BackwardCameraView.canceled -= m_Wrapper.m_CameraControlsActionsCallbackInterface.OnBackwardCameraView;
            }
            m_Wrapper.m_CameraControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @TopCameraView.started += instance.OnTopCameraView;
                @TopCameraView.performed += instance.OnTopCameraView;
                @TopCameraView.canceled += instance.OnTopCameraView;
                @ForwardCameraView.started += instance.OnForwardCameraView;
                @ForwardCameraView.performed += instance.OnForwardCameraView;
                @ForwardCameraView.canceled += instance.OnForwardCameraView;
                @BackwardCameraView.started += instance.OnBackwardCameraView;
                @BackwardCameraView.performed += instance.OnBackwardCameraView;
                @BackwardCameraView.canceled += instance.OnBackwardCameraView;
            }
        }
    }
    public CameraControlsActions @CameraControls => new CameraControlsActions(this);

    // UI Controls
    private readonly InputActionMap m_UIControls;
    private IUIControlsActions m_UIControlsActionsCallbackInterface;
    private readonly InputAction m_UIControls_TogglePause;
    private readonly InputAction m_UIControls_ToggleMap;
    public struct UIControlsActions
    {
        private @PlayerAction m_Wrapper;
        public UIControlsActions(@PlayerAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @TogglePause => m_Wrapper.m_UIControls_TogglePause;
        public InputAction @ToggleMap => m_Wrapper.m_UIControls_ToggleMap;
        public InputActionMap Get() { return m_Wrapper.m_UIControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIControlsActions set) { return set.Get(); }
        public void SetCallbacks(IUIControlsActions instance)
        {
            if (m_Wrapper.m_UIControlsActionsCallbackInterface != null)
            {
                @TogglePause.started -= m_Wrapper.m_UIControlsActionsCallbackInterface.OnTogglePause;
                @TogglePause.performed -= m_Wrapper.m_UIControlsActionsCallbackInterface.OnTogglePause;
                @TogglePause.canceled -= m_Wrapper.m_UIControlsActionsCallbackInterface.OnTogglePause;
                @ToggleMap.started -= m_Wrapper.m_UIControlsActionsCallbackInterface.OnToggleMap;
                @ToggleMap.performed -= m_Wrapper.m_UIControlsActionsCallbackInterface.OnToggleMap;
                @ToggleMap.canceled -= m_Wrapper.m_UIControlsActionsCallbackInterface.OnToggleMap;
            }
            m_Wrapper.m_UIControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @TogglePause.started += instance.OnTogglePause;
                @TogglePause.performed += instance.OnTogglePause;
                @TogglePause.canceled += instance.OnTogglePause;
                @ToggleMap.started += instance.OnToggleMap;
                @ToggleMap.performed += instance.OnToggleMap;
                @ToggleMap.canceled += instance.OnToggleMap;
            }
        }
    }
    public UIControlsActions @UIControls => new UIControlsActions(this);

    // Map Controls
    private readonly InputActionMap m_MapControls;
    private IMapControlsActions m_MapControlsActionsCallbackInterface;
    private readonly InputAction m_MapControls_MapZoom;
    private readonly InputAction m_MapControls_Turn;
    public struct MapControlsActions
    {
        private @PlayerAction m_Wrapper;
        public MapControlsActions(@PlayerAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @MapZoom => m_Wrapper.m_MapControls_MapZoom;
        public InputAction @Turn => m_Wrapper.m_MapControls_Turn;
        public InputActionMap Get() { return m_Wrapper.m_MapControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MapControlsActions set) { return set.Get(); }
        public void SetCallbacks(IMapControlsActions instance)
        {
            if (m_Wrapper.m_MapControlsActionsCallbackInterface != null)
            {
                @MapZoom.started -= m_Wrapper.m_MapControlsActionsCallbackInterface.OnMapZoom;
                @MapZoom.performed -= m_Wrapper.m_MapControlsActionsCallbackInterface.OnMapZoom;
                @MapZoom.canceled -= m_Wrapper.m_MapControlsActionsCallbackInterface.OnMapZoom;
                @Turn.started -= m_Wrapper.m_MapControlsActionsCallbackInterface.OnTurn;
                @Turn.performed -= m_Wrapper.m_MapControlsActionsCallbackInterface.OnTurn;
                @Turn.canceled -= m_Wrapper.m_MapControlsActionsCallbackInterface.OnTurn;
            }
            m_Wrapper.m_MapControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MapZoom.started += instance.OnMapZoom;
                @MapZoom.performed += instance.OnMapZoom;
                @MapZoom.canceled += instance.OnMapZoom;
                @Turn.started += instance.OnTurn;
                @Turn.performed += instance.OnTurn;
                @Turn.canceled += instance.OnTurn;
            }
        }
    }
    public MapControlsActions @MapControls => new MapControlsActions(this);
    private int m_KeyboardQWERTYSchemeIndex = -1;
    public InputControlScheme KeyboardQWERTYScheme
    {
        get
        {
            if (m_KeyboardQWERTYSchemeIndex == -1) m_KeyboardQWERTYSchemeIndex = asset.FindControlSchemeIndex("Keyboard QWERTY");
            return asset.controlSchemes[m_KeyboardQWERTYSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IPlayerControlsActions
    {
        void OnDropPackage(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnSpeed(InputAction.CallbackContext context);
        void OnBoost(InputAction.CallbackContext context);
    }
    public interface ICameraControlsActions
    {
        void OnTopCameraView(InputAction.CallbackContext context);
        void OnForwardCameraView(InputAction.CallbackContext context);
        void OnBackwardCameraView(InputAction.CallbackContext context);
    }
    public interface IUIControlsActions
    {
        void OnTogglePause(InputAction.CallbackContext context);
        void OnToggleMap(InputAction.CallbackContext context);
    }
    public interface IMapControlsActions
    {
        void OnMapZoom(InputAction.CallbackContext context);
        void OnTurn(InputAction.CallbackContext context);
    }
}