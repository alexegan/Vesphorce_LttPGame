// GENERATED AUTOMATICALLY FROM 'Assets/Developer Temp Assets/Input Actions/_inputaction_PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class _inputaction_PlayerInput : IInputActionCollection, IDisposable
{
    private InputActionAsset asset;
    public _inputaction_PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""_inputaction_PlayerInput"",
    ""maps"": [
        {
            ""name"": ""PlayerInput01"",
            ""id"": ""a2d4a2a4-085d-4417-91b9-6557edaf293d"",
            ""actions"": [
                {
                    ""name"": ""input_Movement"",
                    ""type"": ""Value"",
                    ""id"": ""92c3c616-a964-4b23-8a6c-d700aecfffb5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""input_Button_Lower"",
                    ""type"": ""Button"",
                    ""id"": ""8e8b6015-b1b1-4167-84c3-9357757a4ec3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""input_Button_Right"",
                    ""type"": ""Button"",
                    ""id"": ""6dc0fa49-8868-45f1-9fd7-276d9e8045c8"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""f8893acf-23c3-4072-848e-3c38872ed19c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""input_Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""421bd9cf-8d8e-4b89-a9c1-b84a37d67858"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""input_Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1b5ed71c-b95c-40df-92b5-7e9fa5cc93c8"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""input_Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e12fffae-15c7-4332-9cb7-0d90a0323573"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""input_Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""eee7ee3f-8c81-4cf6-a3ac-1914fa685368"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""input_Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""D-Pad"",
                    ""id"": ""bed21d0b-37aa-4f64-afe5-40b9d54719db"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""input_Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""79220ff6-efe0-408a-b500-97ab30b9d774"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""input_Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4989c93d-0df0-4c39-8be9-5cae698254da"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""input_Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""50039b87-ecf7-4572-8db1-60846f8a8164"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""input_Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f1b6dc61-9bfc-44e6-9990-d879a8cccc69"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""input_Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0c8d716a-6106-4b7e-bbed-cfa08e65eecd"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""input_Button_Lower"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b1572806-655c-43bf-894c-6335d23376f4"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""input_Button_Lower"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5ecda0a2-c65c-4baf-ac37-3f76beb65aea"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""input_Button_Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6334a8bf-a8f3-462b-9368-a82ffe78695a"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""input_Button_Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerInput01
        m_PlayerInput01 = asset.FindActionMap("PlayerInput01", throwIfNotFound: true);
        m_PlayerInput01_input_Movement = m_PlayerInput01.FindAction("input_Movement", throwIfNotFound: true);
        m_PlayerInput01_input_Button_Lower = m_PlayerInput01.FindAction("input_Button_Lower", throwIfNotFound: true);
        m_PlayerInput01_input_Button_Right = m_PlayerInput01.FindAction("input_Button_Right", throwIfNotFound: true);
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

    // PlayerInput01
    private readonly InputActionMap m_PlayerInput01;
    private IPlayerInput01Actions m_PlayerInput01ActionsCallbackInterface;
    private readonly InputAction m_PlayerInput01_input_Movement;
    private readonly InputAction m_PlayerInput01_input_Button_Lower;
    private readonly InputAction m_PlayerInput01_input_Button_Right;
    public struct PlayerInput01Actions
    {
        private _inputaction_PlayerInput m_Wrapper;
        public PlayerInput01Actions(_inputaction_PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @input_Movement => m_Wrapper.m_PlayerInput01_input_Movement;
        public InputAction @input_Button_Lower => m_Wrapper.m_PlayerInput01_input_Button_Lower;
        public InputAction @input_Button_Right => m_Wrapper.m_PlayerInput01_input_Button_Right;
        public InputActionMap Get() { return m_Wrapper.m_PlayerInput01; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerInput01Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayerInput01Actions instance)
        {
            if (m_Wrapper.m_PlayerInput01ActionsCallbackInterface != null)
            {
                input_Movement.started -= m_Wrapper.m_PlayerInput01ActionsCallbackInterface.OnInput_Movement;
                input_Movement.performed -= m_Wrapper.m_PlayerInput01ActionsCallbackInterface.OnInput_Movement;
                input_Movement.canceled -= m_Wrapper.m_PlayerInput01ActionsCallbackInterface.OnInput_Movement;
                input_Button_Lower.started -= m_Wrapper.m_PlayerInput01ActionsCallbackInterface.OnInput_Button_Lower;
                input_Button_Lower.performed -= m_Wrapper.m_PlayerInput01ActionsCallbackInterface.OnInput_Button_Lower;
                input_Button_Lower.canceled -= m_Wrapper.m_PlayerInput01ActionsCallbackInterface.OnInput_Button_Lower;
                input_Button_Right.started -= m_Wrapper.m_PlayerInput01ActionsCallbackInterface.OnInput_Button_Right;
                input_Button_Right.performed -= m_Wrapper.m_PlayerInput01ActionsCallbackInterface.OnInput_Button_Right;
                input_Button_Right.canceled -= m_Wrapper.m_PlayerInput01ActionsCallbackInterface.OnInput_Button_Right;
            }
            m_Wrapper.m_PlayerInput01ActionsCallbackInterface = instance;
            if (instance != null)
            {
                input_Movement.started += instance.OnInput_Movement;
                input_Movement.performed += instance.OnInput_Movement;
                input_Movement.canceled += instance.OnInput_Movement;
                input_Button_Lower.started += instance.OnInput_Button_Lower;
                input_Button_Lower.performed += instance.OnInput_Button_Lower;
                input_Button_Lower.canceled += instance.OnInput_Button_Lower;
                input_Button_Right.started += instance.OnInput_Button_Right;
                input_Button_Right.performed += instance.OnInput_Button_Right;
                input_Button_Right.canceled += instance.OnInput_Button_Right;
            }
        }
    }
    public PlayerInput01Actions @PlayerInput01 => new PlayerInput01Actions(this);
    public interface IPlayerInput01Actions
    {
        void OnInput_Movement(InputAction.CallbackContext context);
        void OnInput_Button_Lower(InputAction.CallbackContext context);
        void OnInput_Button_Right(InputAction.CallbackContext context);
    }
}
