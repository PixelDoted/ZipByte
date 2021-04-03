// GENERATED AUTOMATICALLY FROM 'Assets/Input/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace InputControls
{
    public class @Controls : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @Controls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Input"",
            ""id"": ""850e2aca-fefb-43b3-8646-3308fb410db3"",
            ""actions"": [
                {
                    ""name"": ""tap"",
                    ""type"": ""Button"",
                    ""id"": ""dbc33898-6a9a-42c3-b9ba-4a1795b4372f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""tapPosX"",
                    ""type"": ""Value"",
                    ""id"": ""5db9e747-ae8a-4e5c-a4fd-63656e62f703"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""tapPosY"",
                    ""type"": ""Value"",
                    ""id"": ""1421861c-4503-4437-957d-299b54ac2263"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""12f6dac1-40df-439f-84c3-5a772f4322f1"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e3408e9a-5e48-44fa-b7c1-fd91e002457b"",
                    ""path"": ""<Touchscreen>/primaryTouch/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""42f70447-d456-4842-9286-9d5d72886874"",
                    ""path"": ""<Touchscreen>/position/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""tapPosX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d2a5609b-7f63-41e8-9afd-50938390ee2e"",
                    ""path"": ""<Mouse>/position/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""tapPosX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b3262110-6168-4b08-92e9-68f59080965e"",
                    ""path"": ""<Touchscreen>/position/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""tapPosY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f13ae37f-4579-472e-a61c-596198810275"",
                    ""path"": ""<Mouse>/position/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""tapPosY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Input
            m_Input = asset.FindActionMap("Input", throwIfNotFound: true);
            m_Input_tap = m_Input.FindAction("tap", throwIfNotFound: true);
            m_Input_tapPosX = m_Input.FindAction("tapPosX", throwIfNotFound: true);
            m_Input_tapPosY = m_Input.FindAction("tapPosY", throwIfNotFound: true);
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

        // Input
        private readonly InputActionMap m_Input;
        private IInputActions m_InputActionsCallbackInterface;
        private readonly InputAction m_Input_tap;
        private readonly InputAction m_Input_tapPosX;
        private readonly InputAction m_Input_tapPosY;
        public struct InputActions
        {
            private @Controls m_Wrapper;
            public InputActions(@Controls wrapper) { m_Wrapper = wrapper; }
            public InputAction @tap => m_Wrapper.m_Input_tap;
            public InputAction @tapPosX => m_Wrapper.m_Input_tapPosX;
            public InputAction @tapPosY => m_Wrapper.m_Input_tapPosY;
            public InputActionMap Get() { return m_Wrapper.m_Input; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(InputActions set) { return set.Get(); }
            public void SetCallbacks(IInputActions instance)
            {
                if (m_Wrapper.m_InputActionsCallbackInterface != null)
                {
                    @tap.started -= m_Wrapper.m_InputActionsCallbackInterface.OnTap;
                    @tap.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnTap;
                    @tap.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnTap;
                    @tapPosX.started -= m_Wrapper.m_InputActionsCallbackInterface.OnTapPosX;
                    @tapPosX.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnTapPosX;
                    @tapPosX.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnTapPosX;
                    @tapPosY.started -= m_Wrapper.m_InputActionsCallbackInterface.OnTapPosY;
                    @tapPosY.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnTapPosY;
                    @tapPosY.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnTapPosY;
                }
                m_Wrapper.m_InputActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @tap.started += instance.OnTap;
                    @tap.performed += instance.OnTap;
                    @tap.canceled += instance.OnTap;
                    @tapPosX.started += instance.OnTapPosX;
                    @tapPosX.performed += instance.OnTapPosX;
                    @tapPosX.canceled += instance.OnTapPosX;
                    @tapPosY.started += instance.OnTapPosY;
                    @tapPosY.performed += instance.OnTapPosY;
                    @tapPosY.canceled += instance.OnTapPosY;
                }
            }
        }
        public InputActions @Input => new InputActions(this);
        public interface IInputActions
        {
            void OnTap(InputAction.CallbackContext context);
            void OnTapPosX(InputAction.CallbackContext context);
            void OnTapPosY(InputAction.CallbackContext context);
        }
    }
}
