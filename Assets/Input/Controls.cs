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
            ""name"": ""MouseInput"",
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
        },
        {
            ""name"": ""TouchInput"",
            ""id"": ""03c93844-e87e-4e1c-a243-6391341d397d"",
            ""actions"": [
                {
                    ""name"": ""tap"",
                    ""type"": ""Button"",
                    ""id"": ""2b4710ff-7f4e-4b18-99bc-d25a1c81bfdc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""tapPosX"",
                    ""type"": ""Value"",
                    ""id"": ""1208ffa6-cf8c-4f4d-9cf3-6b3f0d7fe4c8"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""tapPosY"",
                    ""type"": ""Value"",
                    ""id"": ""8b86c8d4-5aab-422d-96c3-5f3176591c1f"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""77036d4d-85c1-4008-a5af-75df31b6b216"",
                    ""path"": ""<Touchscreen>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""78279bd8-2be3-4718-9a63-0bb3f821674f"",
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
                    ""id"": ""d4054118-f7e8-4654-9bd7-4441888056f3"",
                    ""path"": ""<Touchscreen>/position/y"",
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
            // MouseInput
            m_MouseInput = asset.FindActionMap("MouseInput", throwIfNotFound: true);
            m_MouseInput_tap = m_MouseInput.FindAction("tap", throwIfNotFound: true);
            m_MouseInput_tapPosX = m_MouseInput.FindAction("tapPosX", throwIfNotFound: true);
            m_MouseInput_tapPosY = m_MouseInput.FindAction("tapPosY", throwIfNotFound: true);
            // TouchInput
            m_TouchInput = asset.FindActionMap("TouchInput", throwIfNotFound: true);
            m_TouchInput_tap = m_TouchInput.FindAction("tap", throwIfNotFound: true);
            m_TouchInput_tapPosX = m_TouchInput.FindAction("tapPosX", throwIfNotFound: true);
            m_TouchInput_tapPosY = m_TouchInput.FindAction("tapPosY", throwIfNotFound: true);
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

        // MouseInput
        private readonly InputActionMap m_MouseInput;
        private IMouseInputActions m_MouseInputActionsCallbackInterface;
        private readonly InputAction m_MouseInput_tap;
        private readonly InputAction m_MouseInput_tapPosX;
        private readonly InputAction m_MouseInput_tapPosY;
        public struct MouseInputActions
        {
            private @Controls m_Wrapper;
            public MouseInputActions(@Controls wrapper) { m_Wrapper = wrapper; }
            public InputAction @tap => m_Wrapper.m_MouseInput_tap;
            public InputAction @tapPosX => m_Wrapper.m_MouseInput_tapPosX;
            public InputAction @tapPosY => m_Wrapper.m_MouseInput_tapPosY;
            public InputActionMap Get() { return m_Wrapper.m_MouseInput; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(MouseInputActions set) { return set.Get(); }
            public void SetCallbacks(IMouseInputActions instance)
            {
                if (m_Wrapper.m_MouseInputActionsCallbackInterface != null)
                {
                    @tap.started -= m_Wrapper.m_MouseInputActionsCallbackInterface.OnTap;
                    @tap.performed -= m_Wrapper.m_MouseInputActionsCallbackInterface.OnTap;
                    @tap.canceled -= m_Wrapper.m_MouseInputActionsCallbackInterface.OnTap;
                    @tapPosX.started -= m_Wrapper.m_MouseInputActionsCallbackInterface.OnTapPosX;
                    @tapPosX.performed -= m_Wrapper.m_MouseInputActionsCallbackInterface.OnTapPosX;
                    @tapPosX.canceled -= m_Wrapper.m_MouseInputActionsCallbackInterface.OnTapPosX;
                    @tapPosY.started -= m_Wrapper.m_MouseInputActionsCallbackInterface.OnTapPosY;
                    @tapPosY.performed -= m_Wrapper.m_MouseInputActionsCallbackInterface.OnTapPosY;
                    @tapPosY.canceled -= m_Wrapper.m_MouseInputActionsCallbackInterface.OnTapPosY;
                }
                m_Wrapper.m_MouseInputActionsCallbackInterface = instance;
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
        public MouseInputActions @MouseInput => new MouseInputActions(this);

        // TouchInput
        private readonly InputActionMap m_TouchInput;
        private ITouchInputActions m_TouchInputActionsCallbackInterface;
        private readonly InputAction m_TouchInput_tap;
        private readonly InputAction m_TouchInput_tapPosX;
        private readonly InputAction m_TouchInput_tapPosY;
        public struct TouchInputActions
        {
            private @Controls m_Wrapper;
            public TouchInputActions(@Controls wrapper) { m_Wrapper = wrapper; }
            public InputAction @tap => m_Wrapper.m_TouchInput_tap;
            public InputAction @tapPosX => m_Wrapper.m_TouchInput_tapPosX;
            public InputAction @tapPosY => m_Wrapper.m_TouchInput_tapPosY;
            public InputActionMap Get() { return m_Wrapper.m_TouchInput; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(TouchInputActions set) { return set.Get(); }
            public void SetCallbacks(ITouchInputActions instance)
            {
                if (m_Wrapper.m_TouchInputActionsCallbackInterface != null)
                {
                    @tap.started -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnTap;
                    @tap.performed -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnTap;
                    @tap.canceled -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnTap;
                    @tapPosX.started -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnTapPosX;
                    @tapPosX.performed -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnTapPosX;
                    @tapPosX.canceled -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnTapPosX;
                    @tapPosY.started -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnTapPosY;
                    @tapPosY.performed -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnTapPosY;
                    @tapPosY.canceled -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnTapPosY;
                }
                m_Wrapper.m_TouchInputActionsCallbackInterface = instance;
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
        public TouchInputActions @TouchInput => new TouchInputActions(this);
        public interface IMouseInputActions
        {
            void OnTap(InputAction.CallbackContext context);
            void OnTapPosX(InputAction.CallbackContext context);
            void OnTapPosY(InputAction.CallbackContext context);
        }
        public interface ITouchInputActions
        {
            void OnTap(InputAction.CallbackContext context);
            void OnTapPosX(InputAction.CallbackContext context);
            void OnTapPosY(InputAction.CallbackContext context);
        }
    }
}
