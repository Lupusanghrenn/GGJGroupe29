// GENERATED AUTOMATICALLY FROM 'Assets/Input/ControlMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ControlMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @ControlMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ControlMaster"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""5ee48ad7-2dad-474d-ab3f-9bbc54e3daad"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""ecf6b624-1f09-44f3-9d27-8e3ab972341f"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Action"",
                    ""type"": ""Button"",
                    ""id"": ""85843622-a712-4dd2-9092-285ee010b3f0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Release"",
                    ""type"": ""Button"",
                    ""id"": ""f447dde0-cb1e-4fd3-b87b-d693d0ed1668"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""43fddf9b-e75b-4510-ae9a-197939f9fc82"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""MoveVector"",
                    ""id"": ""1bd7830f-dbd9-40a2-b57c-08cd35ac1080"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a14d9834-84fd-4026-94ef-1064643515d9"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""043d49c4-d0e8-4047-979b-16d4fea47155"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0fd230de-bd78-4579-ae78-58aa2e95a479"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""019e3484-290d-46a3-8d08-2259b254b149"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0f560a3a-34c0-4d49-b4db-94c50b3b0ec8"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5fdff9ff-5681-48b7-82ee-a139481c7781"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""12566a4c-5d19-4dfd-bb15-3542cb4a68d9"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""19e1eb3e-12a2-4743-9e4a-d54ce5112803"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""aef31b83-4e06-4433-ac9c-5beb500a0cd9"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0eb3383e-5a5a-4508-97d8-e841c0e86ec0"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9665ac1e-5662-4064-b88d-fe1b7f773165"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5e0ddd33-7baa-4933-b911-827ba6d1462c"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Release"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dd212f50-d042-411e-8a08-da4db0a5a639"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Release"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d71c7a1a-7e95-4cee-b246-69474863f7c0"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""911b123f-9ff4-422d-b19b-58a0126f463d"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player1"",
            ""id"": ""136497cf-a9d2-401a-b021-3c90ddca1c54"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""ccf909f2-8590-4cb4-9486-7f51e44500df"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Action"",
                    ""type"": ""Button"",
                    ""id"": ""97815125-f2cf-4c4b-9f70-88c17aed9abc"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Release"",
                    ""type"": ""Button"",
                    ""id"": ""5203ab72-23ba-44ad-ab40-5b3c9bde4177"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""8e7114d1-570b-44fc-b020-cb2a4e993ed5"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""MoveVector"",
                    ""id"": ""bc972d9f-ff9b-44c5-96d8-6ff211792ce8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a0c9ad7f-90bb-49f2-ab97-a04f9db6ab49"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""fd2ec64f-c1d8-44c5-bb69-1cea6e61584b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b4c2cb1b-9cba-4650-993b-c80044515d63"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6d34a1a5-7f9b-46ad-890a-95709e89cde2"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""94490961-5d3d-4a53-8a58-e467afa916e8"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5a986335-4b9d-4272-8dc9-9a24be0a748b"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e286ab74-7880-4a3d-9fa1-4dc647d122e9"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""469fef11-46a2-4e49-af56-5f28052b577c"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bb6c7fcf-8634-4377-92d8-a5a62f9b9f8d"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""46ca8cb7-114e-4e23-81e5-53a3a73ab20d"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5739f62b-1c4b-4019-b118-96c2b6209bdc"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3e558b21-5311-48c4-a95f-9765be1a4a42"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Release"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1406abcb-f7a0-4df5-b4c5-0adbad0e8c28"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Release"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""29d5e275-5bd1-4604-aa53-dd0887b81b25"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""de9aa48e-68b2-41fc-a208-66e379f29e87"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Ladder"",
            ""id"": ""acc0f819-ea71-4c16-a492-2fcdfab75165"",
            ""actions"": [
                {
                    ""name"": ""MoveLadder"",
                    ""type"": ""Value"",
                    ""id"": ""cbea6e99-fafc-4882-82ef-1cb964830f6e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ActionLadder"",
                    ""type"": ""Button"",
                    ""id"": ""86662fd4-f9c9-45f0-bae0-53e22852b0dd"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""MoveLadder"",
                    ""id"": ""aaf9f5d2-42aa-49fd-9b02-7ae0b6f6f3d1"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLadder"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""3a259a76-e2f0-4213-84f5-d0d86a5fcad4"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveLadder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e27e96e4-6e8d-4a22-9664-8d0c9e13763e"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveLadder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""979023c2-cfee-438a-b7c7-30f4d8cea3d3"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveLadder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3a4385b9-e564-40b6-930d-5fee00ef6ff5"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveLadder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""beb73ed1-a579-4599-9687-d97e20a311a7"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MoveLadder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""4b206de4-1f9d-44c9-b3e4-6f9279bd1d9f"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MoveLadder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f1fdd9d1-8740-4a97-b9ab-1d6b526ceb7e"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ActionLadder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1723d4fe-0652-48fb-8082-6c423af75ccf"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ActionLadder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Canon"",
            ""id"": ""1b441abd-983e-437e-b437-e9f2121ed072"",
            ""actions"": [
                {
                    ""name"": ""FireCanon"",
                    ""type"": ""Button"",
                    ""id"": ""975ed8b5-e921-4970-ae79-ec1db4fc9221"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveCanon"",
                    ""type"": ""Button"",
                    ""id"": ""3e95570e-c906-4014-93af-0917a981d8d1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""49a2213e-48ea-45cf-974b-70f1ebd344e0"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""FireCanon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f5d02a70-a587-4924-b493-612b8ff025ff"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""FireCanon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""9fbf1f55-40a9-4ec7-9320-49d44d47948d"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCanon"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""9f2159ce-29e1-4a9d-8591-09461968ec9b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveCanon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""8815b234-5de5-4691-8d29-ceeaa88e7181"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveCanon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""0637546b-6661-45bb-8be4-997fba5c7c5a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCanon"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a5a248ac-3b87-4179-ae60-09e79263d4f2"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveCanon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""56a9c2c8-3d04-4485-b829-de1559647564"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveCanon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""33920113-fe15-4385-b853-2a803a1bf29d"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCanon"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""8ce5ed57-6467-49f6-9161-c757602b05e2"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCanon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""bca45f87-8964-4b58-ba79-d5903bd49412"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCanon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
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
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Action = m_Player.FindAction("Action", throwIfNotFound: true);
        m_Player_Release = m_Player.FindAction("Release", throwIfNotFound: true);
        m_Player_Pause = m_Player.FindAction("Pause", throwIfNotFound: true);
        // Player1
        m_Player1 = asset.FindActionMap("Player1", throwIfNotFound: true);
        m_Player1_Move = m_Player1.FindAction("Move", throwIfNotFound: true);
        m_Player1_Action = m_Player1.FindAction("Action", throwIfNotFound: true);
        m_Player1_Release = m_Player1.FindAction("Release", throwIfNotFound: true);
        m_Player1_Pause = m_Player1.FindAction("Pause", throwIfNotFound: true);
        // Ladder
        m_Ladder = asset.FindActionMap("Ladder", throwIfNotFound: true);
        m_Ladder_MoveLadder = m_Ladder.FindAction("MoveLadder", throwIfNotFound: true);
        m_Ladder_ActionLadder = m_Ladder.FindAction("ActionLadder", throwIfNotFound: true);
        // Canon
        m_Canon = asset.FindActionMap("Canon", throwIfNotFound: true);
        m_Canon_FireCanon = m_Canon.FindAction("FireCanon", throwIfNotFound: true);
        m_Canon_MoveCanon = m_Canon.FindAction("MoveCanon", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Action;
    private readonly InputAction m_Player_Release;
    private readonly InputAction m_Player_Pause;
    public struct PlayerActions
    {
        private @ControlMaster m_Wrapper;
        public PlayerActions(@ControlMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Action => m_Wrapper.m_Player_Action;
        public InputAction @Release => m_Wrapper.m_Player_Release;
        public InputAction @Pause => m_Wrapper.m_Player_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Action.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction;
                @Action.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction;
                @Action.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction;
                @Release.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRelease;
                @Release.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRelease;
                @Release.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRelease;
                @Pause.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Action.started += instance.OnAction;
                @Action.performed += instance.OnAction;
                @Action.canceled += instance.OnAction;
                @Release.started += instance.OnRelease;
                @Release.performed += instance.OnRelease;
                @Release.canceled += instance.OnRelease;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Player1
    private readonly InputActionMap m_Player1;
    private IPlayer1Actions m_Player1ActionsCallbackInterface;
    private readonly InputAction m_Player1_Move;
    private readonly InputAction m_Player1_Action;
    private readonly InputAction m_Player1_Release;
    private readonly InputAction m_Player1_Pause;
    public struct Player1Actions
    {
        private @ControlMaster m_Wrapper;
        public Player1Actions(@ControlMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player1_Move;
        public InputAction @Action => m_Wrapper.m_Player1_Action;
        public InputAction @Release => m_Wrapper.m_Player1_Release;
        public InputAction @Pause => m_Wrapper.m_Player1_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Player1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player1Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer1Actions instance)
        {
            if (m_Wrapper.m_Player1ActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMove;
                @Action.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnAction;
                @Action.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnAction;
                @Action.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnAction;
                @Release.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnRelease;
                @Release.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnRelease;
                @Release.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnRelease;
                @Pause.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_Player1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Action.started += instance.OnAction;
                @Action.performed += instance.OnAction;
                @Action.canceled += instance.OnAction;
                @Release.started += instance.OnRelease;
                @Release.performed += instance.OnRelease;
                @Release.canceled += instance.OnRelease;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public Player1Actions @Player1 => new Player1Actions(this);

    // Ladder
    private readonly InputActionMap m_Ladder;
    private ILadderActions m_LadderActionsCallbackInterface;
    private readonly InputAction m_Ladder_MoveLadder;
    private readonly InputAction m_Ladder_ActionLadder;
    public struct LadderActions
    {
        private @ControlMaster m_Wrapper;
        public LadderActions(@ControlMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveLadder => m_Wrapper.m_Ladder_MoveLadder;
        public InputAction @ActionLadder => m_Wrapper.m_Ladder_ActionLadder;
        public InputActionMap Get() { return m_Wrapper.m_Ladder; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LadderActions set) { return set.Get(); }
        public void SetCallbacks(ILadderActions instance)
        {
            if (m_Wrapper.m_LadderActionsCallbackInterface != null)
            {
                @MoveLadder.started -= m_Wrapper.m_LadderActionsCallbackInterface.OnMoveLadder;
                @MoveLadder.performed -= m_Wrapper.m_LadderActionsCallbackInterface.OnMoveLadder;
                @MoveLadder.canceled -= m_Wrapper.m_LadderActionsCallbackInterface.OnMoveLadder;
                @ActionLadder.started -= m_Wrapper.m_LadderActionsCallbackInterface.OnActionLadder;
                @ActionLadder.performed -= m_Wrapper.m_LadderActionsCallbackInterface.OnActionLadder;
                @ActionLadder.canceled -= m_Wrapper.m_LadderActionsCallbackInterface.OnActionLadder;
            }
            m_Wrapper.m_LadderActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveLadder.started += instance.OnMoveLadder;
                @MoveLadder.performed += instance.OnMoveLadder;
                @MoveLadder.canceled += instance.OnMoveLadder;
                @ActionLadder.started += instance.OnActionLadder;
                @ActionLadder.performed += instance.OnActionLadder;
                @ActionLadder.canceled += instance.OnActionLadder;
            }
        }
    }
    public LadderActions @Ladder => new LadderActions(this);

    // Canon
    private readonly InputActionMap m_Canon;
    private ICanonActions m_CanonActionsCallbackInterface;
    private readonly InputAction m_Canon_FireCanon;
    private readonly InputAction m_Canon_MoveCanon;
    public struct CanonActions
    {
        private @ControlMaster m_Wrapper;
        public CanonActions(@ControlMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @FireCanon => m_Wrapper.m_Canon_FireCanon;
        public InputAction @MoveCanon => m_Wrapper.m_Canon_MoveCanon;
        public InputActionMap Get() { return m_Wrapper.m_Canon; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CanonActions set) { return set.Get(); }
        public void SetCallbacks(ICanonActions instance)
        {
            if (m_Wrapper.m_CanonActionsCallbackInterface != null)
            {
                @FireCanon.started -= m_Wrapper.m_CanonActionsCallbackInterface.OnFireCanon;
                @FireCanon.performed -= m_Wrapper.m_CanonActionsCallbackInterface.OnFireCanon;
                @FireCanon.canceled -= m_Wrapper.m_CanonActionsCallbackInterface.OnFireCanon;
                @MoveCanon.started -= m_Wrapper.m_CanonActionsCallbackInterface.OnMoveCanon;
                @MoveCanon.performed -= m_Wrapper.m_CanonActionsCallbackInterface.OnMoveCanon;
                @MoveCanon.canceled -= m_Wrapper.m_CanonActionsCallbackInterface.OnMoveCanon;
            }
            m_Wrapper.m_CanonActionsCallbackInterface = instance;
            if (instance != null)
            {
                @FireCanon.started += instance.OnFireCanon;
                @FireCanon.performed += instance.OnFireCanon;
                @FireCanon.canceled += instance.OnFireCanon;
                @MoveCanon.started += instance.OnMoveCanon;
                @MoveCanon.performed += instance.OnMoveCanon;
                @MoveCanon.canceled += instance.OnMoveCanon;
            }
        }
    }
    public CanonActions @Canon => new CanonActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
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
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnAction(InputAction.CallbackContext context);
        void OnRelease(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
    public interface IPlayer1Actions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnAction(InputAction.CallbackContext context);
        void OnRelease(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
    public interface ILadderActions
    {
        void OnMoveLadder(InputAction.CallbackContext context);
        void OnActionLadder(InputAction.CallbackContext context);
    }
    public interface ICanonActions
    {
        void OnFireCanon(InputAction.CallbackContext context);
        void OnMoveCanon(InputAction.CallbackContext context);
    }
}
