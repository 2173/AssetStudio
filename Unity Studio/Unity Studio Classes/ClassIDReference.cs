﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Unity_Studio
{
    public class ClassStruct : ListViewItem
    {
        public int ID;
        public List<ClassMember> members;

        public string membersstr
        {
            get
            {
                var sb = new StringBuilder();
                foreach (var i in members)
                {
                    sb.AppendFormat("{0}{1} {2} {3}\r\n", (new string('\t', i.Level)), i.Type, i.Name, i.Size);
                }
                return sb.ToString();
            }
        }
    }

    public class ClassMember
    {
        public int Level;
        public string Type;
        public string Name;
        public int Size;
    }

    public class ClassIDReference
    {
        public string[] Names = new string[1121];

        public ClassIDReference()
        {
            Names[1] = "GameObject";
            Names[2] = "Component";
            Names[3] = "LevelGameManager";
            Names[4] = "Transform";
            Names[5] = "TimeManager";
            Names[6] = "GlobalGameManager";
            Names[8] = "Behaviour";
            Names[9] = "GameManager";
            Names[11] = "AudioManager";
            Names[12] = "ParticleAnimator";
            Names[13] = "InputManager";
            Names[15] = "EllipsoidParticleEmitter";
            Names[17] = "Pipeline";
            Names[18] = "EditorExtension";
            Names[19] = "Physics2DSettings";
            Names[20] = "Camera";
            Names[21] = "Material";
            Names[23] = "MeshRenderer";
            Names[25] = "Renderer";
            Names[26] = "ParticleRenderer";
            Names[27] = "Texture";
            Names[28] = "Texture2D";
            Names[29] = "SceneSettings";
            Names[30] = "GraphicsSettings";
            Names[33] = "MeshFilter";
            Names[41] = "OcclusionPortal";
            Names[43] = "Mesh";
            Names[45] = "Skybox";
            Names[47] = "QualitySettings";
            Names[48] = "Shader";
            Names[49] = "TextAsset";
            Names[50] = "Rigidbody2D";
            Names[51] = "Physics2DManager";
            Names[53] = "Collider2D";
            Names[54] = "Rigidbody";
            Names[55] = "PhysicsManager";
            Names[56] = "Collider";
            Names[57] = "Joint";
            Names[58] = "CircleCollider2D";
            Names[59] = "HingeJoint";
            Names[60] = "PolygonCollider2D";
            Names[61] = "BoxCollider2D";
            Names[62] = "PhysicsMaterial2D";
            Names[64] = "MeshCollider";
            Names[65] = "BoxCollider";
            Names[66] = "SpriteCollider2D";
            Names[68] = "EdgeCollider2D";
            Names[72] = "ComputeShader";
            Names[74] = "AnimationClip";
            Names[75] = "ConstantForce";
            Names[76] = "WorldParticleCollider";
            Names[78] = "TagManager";
            Names[81] = "AudioListener";
            Names[82] = "AudioSource";
            Names[83] = "AudioClip";
            Names[84] = "RenderTexture";
            Names[87] = "MeshParticleEmitter";
            Names[88] = "ParticleEmitter";
            Names[89] = "Cubemap";
            Names[90] = "Avatar";
            Names[91] = "AnimatorController";
            Names[92] = "GUILayer";
            Names[93] = "RuntimeAnimatorController";
            Names[94] = "ScriptMapper";
            Names[95] = "Animator";
            Names[96] = "TrailRenderer";
            Names[98] = "DelayedCallManager";
            Names[102] = "TextMesh";
            Names[104] = "RenderSettings";
            Names[108] = "Light";
            Names[109] = "CGProgram";
            Names[110] = "BaseAnimationTrack";
            Names[111] = "Animation";
            Names[114] = "MonoBehaviour";
            Names[115] = "MonoScript";
            Names[116] = "MonoManager";
            Names[117] = "Texture3D";
            Names[118] = "NewAnimationTrack";
            Names[119] = "Projector";
            Names[120] = "LineRenderer";
            Names[121] = "Flare";
            Names[122] = "Halo";
            Names[123] = "LensFlare";
            Names[124] = "FlareLayer";
            Names[125] = "HaloLayer";
            Names[126] = "NavMeshAreas";
            Names[127] = "HaloManager";
            Names[128] = "Font";
            Names[129] = "PlayerSettings";
            Names[130] = "NamedObject";
            Names[131] = "GUITexture";
            Names[132] = "GUIText";
            Names[133] = "GUIElement";
            Names[134] = "PhysicMaterial";
            Names[135] = "SphereCollider";
            Names[136] = "CapsuleCollider";
            Names[137] = "SkinnedMeshRenderer";
            Names[138] = "FixedJoint";
            Names[140] = "RaycastCollider";
            Names[141] = "BuildSettings";
            Names[142] = "AssetBundle";
            Names[143] = "CharacterController";
            Names[144] = "CharacterJoint";
            Names[145] = "SpringJoint";
            Names[146] = "WheelCollider";
            Names[147] = "ResourceManager";
            Names[148] = "NetworkView";
            Names[149] = "NetworkManager";
            Names[150] = "PreloadData";
            Names[152] = "MovieTexture";
            Names[153] = "ConfigurableJoint";
            Names[154] = "TerrainCollider";
            Names[155] = "MasterServerInterface";
            Names[156] = "TerrainData";
            Names[157] = "LightmapSettings";
            Names[158] = "WebCamTexture";
            Names[159] = "EditorSettings";
            Names[160] = "InteractiveCloth";
            Names[161] = "ClothRenderer";
            Names[162] = "EditorUserSettings";
            Names[163] = "SkinnedCloth";
            Names[164] = "AudioReverbFilter";
            Names[165] = "AudioHighPassFilter";
            Names[166] = "AudioChorusFilter";
            Names[167] = "AudioReverbZone";
            Names[168] = "AudioEchoFilter";
            Names[169] = "AudioLowPassFilter";
            Names[170] = "AudioDistortionFilter";
            Names[171] = "SparseTexture";
            Names[180] = "AudioBehaviour";
            Names[181] = "AudioFilter";
            Names[182] = "WindZone";
            Names[183] = "Cloth";
            Names[184] = "SubstanceArchive";
            Names[185] = "ProceduralMaterial";
            Names[186] = "ProceduralTexture";
            Names[191] = "OffMeshLink";
            Names[192] = "OcclusionArea";
            Names[193] = "Tree";
            Names[194] = "NavMeshObsolete";
            Names[195] = "NavMeshAgent";
            Names[196] = "NavMeshSettings";
            Names[197] = "LightProbesLegacy";
            Names[198] = "ParticleSystem";
            Names[199] = "ParticleSystemRenderer";
            Names[200] = "ShaderVariantCollection";
            Names[205] = "LODGroup";
            Names[206] = "BlendTree";
            Names[207] = "Motion";
            Names[208] = "NavMeshObstacle";
            Names[210] = "TerrainInstance";
            Names[212] = "SpriteRenderer";
            Names[213] = "Sprite";
            Names[214] = "CachedSpriteAtlas";
            Names[215] = "ReflectionProbe";
            Names[216] = "ReflectionProbes";
            Names[220] = "LightProbeGroup";
            Names[221] = "AnimatorOverrideController";
            Names[222] = "CanvasRenderer";
            Names[223] = "Canvas";
            Names[224] = "RectTransform";
            Names[225] = "CanvasGroup";
            Names[226] = "BillboardAsset";
            Names[227] = "BillboardRenderer";
            Names[228] = "SpeedTreeWindAsset";
            Names[229] = "AnchoredJoint2D";
            Names[230] = "Joint2D";
            Names[231] = "SpringJoint2D";
            Names[232] = "DistanceJoint2D";
            Names[233] = "HingeJoint2D";
            Names[234] = "SliderJoint2D";
            Names[235] = "WheelJoint2D";
            Names[238] = "NavMeshData";
            Names[240] = "AudioMixer";
            Names[241] = "AudioMixerController";
            Names[243] = "AudioMixerGroupController";
            Names[244] = "AudioMixerEffectController";
            Names[245] = "AudioMixerSnapshotController";
            Names[246] = "PhysicsUpdateBehaviour2D";
            Names[247] = "ConstantForce2D";
            Names[248] = "Effector2D";
            Names[249] = "AreaEffector2D";
            Names[250] = "PointEffector2D";
            Names[251] = "PlatformEffector2D";
            Names[252] = "SurfaceEffector2D";
            Names[258] = "LightProbes";
            Names[271] = "SampleClip";
            Names[272] = "AudioMixerSnapshot";
            Names[273] = "AudioMixerGroup";
            Names[290] = "AssetBundleManifest";
            Names[300] = "RuntimeInitializeOnLoadManager";
            Names[301] = "CloudWebServicesManager";
            Names[310] = "UnityConnectSettings";
            Names[1001] = "Prefab";
            Names[1002] = "EditorExtensionImpl";
            Names[1003] = "AssetImporter";
            Names[1004] = "AssetDatabase";
            Names[1005] = "Mesh3DSImporter";
            Names[1006] = "TextureImporter";
            Names[1007] = "ShaderImporter";
            Names[1008] = "ComputeShaderImporter";
            Names[1011] = "AvatarMask";
            Names[1020] = "AudioImporter";
            Names[1026] = "HierarchyState";
            Names[1027] = "GUIDSerializer";
            Names[1028] = "AssetMetaData";
            Names[1029] = "DefaultAsset";
            Names[1030] = "DefaultImporter";
            Names[1031] = "TextScriptImporter";
            Names[1032] = "SceneAsset";
            Names[1034] = "NativeFormatImporter";
            Names[1035] = "MonoImporter";
            Names[1037] = "AssetServerCache";
            Names[1038] = "LibraryAssetImporter";
            Names[1040] = "ModelImporter";
            Names[1041] = "FBXImporter";
            Names[1042] = "TrueTypeFontImporter";
            Names[1044] = "MovieImporter";
            Names[1045] = "EditorBuildSettings";
            Names[1046] = "DDSImporter";
            Names[1048] = "InspectorExpandedState";
            Names[1049] = "AnnotationManager";
            Names[1050] = "PluginImporter";
            Names[1051] = "EditorUserBuildSettings";
            Names[1052] = "PVRImporter";
            Names[1053] = "ASTCImporter";
            Names[1054] = "KTXImporter";
            Names[1101] = "AnimatorStateTransition";
            Names[1102] = "AnimatorState";
            Names[1105] = "HumanTemplate";
            Names[1107] = "AnimatorStateMachine";
            Names[1108] = "PreviewAssetType";
            Names[1109] = "AnimatorTransition";
            Names[1110] = "SpeedTreeImporter";
            Names[1111] = "AnimatorTransitionBase";
            Names[1112] = "SubstanceImporter";
            Names[1113] = "LightmapParameters";
            Names[1120] = "LightmapSnapshot";
        }

    }
}