// Copyright (c) coherence ApS.
// For all coherence generated code, the coherence SDK license terms apply. See the license file in the coherence Package root folder for more information.

// <auto-generated>
// Generated file. DO NOT EDIT!
// </auto-generated>
namespace Coherence.Generated
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using UnityEngine;
	using Coherence.Toolkit;
	using Coherence.Toolkit.Bindings;
	using Coherence.Entity;
	using Coherence.ProtocolDef;
	using Coherence.Brook;
	using Coherence.Toolkit.Bindings.ValueBindings;
	using Coherence.Toolkit.Bindings.TransformBindings;
	using Coherence.Connection;
	using Coherence.Log;
	using Logger = Coherence.Log.Logger;
	using UnityEngine.Scripting;

	public class Binding_5b66f4ea00578924390ab3ef8489d129_b1b0e650_dd3d_46fb_a4f7_78800006a05e : DeepPositionBinding
	{
		private UnityEngine.Transform CastedUnityComponent;		

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (UnityEngine.Transform)UnityComponent;
		}
		public override string CoherenceComponentName => "First__char_32_Person__char_32_Player_id4_UnityEngine__char_46_Transform_7842236257865821986";

		public override uint FieldMask => 0b00000000000000000000000000000001;

		public override Vector3 Value
		{
			get => (Vector3)(UnityEngine.Vector3)(CastedUnityComponent.localPosition);
			set => CastedUnityComponent.localPosition = (UnityEngine.Vector3)(value);
		}

		protected override Vector3 ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (First__char_32_Person__char_32_Player_id4_UnityEngine__char_46_Transform_7842236257865821986)coherenceComponent;
			return update.position;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (First__char_32_Person__char_32_Player_id4_UnityEngine__char_46_Transform_7842236257865821986)coherenceComponent;
			update.position = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new First__char_32_Person__char_32_Player_id4_UnityEngine__char_46_Transform_7842236257865821986();
		}
	}

	public class Binding_5b66f4ea00578924390ab3ef8489d129_5402b0de_e341_4b2c_b26a_2d7ae7281642 : DeepScaleBinding
	{
		private UnityEngine.Transform CastedUnityComponent;		

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (UnityEngine.Transform)UnityComponent;
		}
		public override string CoherenceComponentName => "First__char_32_Person__char_32_Player_id4_UnityEngine__char_46_Transform_7842236257865821986";

		public override uint FieldMask => 0b00000000000000000000000000000010;

		public override Vector3 Value
		{
			get => (Vector3)(UnityEngine.Vector3)(CastedUnityComponent.localScale);
			set => CastedUnityComponent.localScale = (UnityEngine.Vector3)(value);
		}

		protected override Vector3 ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (First__char_32_Person__char_32_Player_id4_UnityEngine__char_46_Transform_7842236257865821986)coherenceComponent;
			return update.localScale;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (First__char_32_Person__char_32_Player_id4_UnityEngine__char_46_Transform_7842236257865821986)coherenceComponent;
			update.localScale = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new First__char_32_Person__char_32_Player_id4_UnityEngine__char_46_Transform_7842236257865821986();
		}
	}

	public class Binding_5b66f4ea00578924390ab3ef8489d129_e26b44ff_0003_47ba_8054_ffff631c3717 : DeepRotationBinding
	{
		private UnityEngine.Transform CastedUnityComponent;		

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (UnityEngine.Transform)UnityComponent;
		}
		public override string CoherenceComponentName => "First__char_32_Person__char_32_Player_id4_UnityEngine__char_46_Transform_7842236257865821986";

		public override uint FieldMask => 0b00000000000000000000000000000100;

		public override Quaternion Value
		{
			get => (Quaternion)(UnityEngine.Quaternion)(CastedUnityComponent.localRotation);
			set => CastedUnityComponent.localRotation = (UnityEngine.Quaternion)(value);
		}

		protected override Quaternion ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (First__char_32_Person__char_32_Player_id4_UnityEngine__char_46_Transform_7842236257865821986)coherenceComponent;
			return update.rotation;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (First__char_32_Person__char_32_Player_id4_UnityEngine__char_46_Transform_7842236257865821986)coherenceComponent;
			update.rotation = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new First__char_32_Person__char_32_Player_id4_UnityEngine__char_46_Transform_7842236257865821986();
		}
	}


	[Preserve]
	[AddComponentMenu("coherence/Baked/Baked 'First Person Player' (auto assigned)")]
	[RequireComponent(typeof(CoherenceSync))]
	public class CoherenceSyncFirst__char_32_Person__char_32_Player_id4 : CoherenceSyncBaked
	{
		private CoherenceSync coherenceSync;
		private Logger logger;

		// Cached targets for commands

		private IClient client;
		private CoherenceMonoBridge monoBridge => coherenceSync.MonoBridge;

		protected void Awake()
		{
			coherenceSync = GetComponent<CoherenceSync>();
			coherenceSync.usingReflection = false;

			logger = coherenceSync.logger.With<CoherenceSyncFirst__char_32_Person__char_32_Player_id4>();
			if (coherenceSync.TryGetBindingByGuid("b1b0e650-dd3d-46fb-a4f7-78800006a05e", "position", out Binding InternalFirst__char_32_Person__char_32_Player_id4_UnityEngine__char_46_Transform_7842236257865821986_First__char_32_Person__char_32_Player_id4_UnityEngine__char_46_Transform_7842236257865821986_position))
			{
				var clone = new Binding_5b66f4ea00578924390ab3ef8489d129_b1b0e650_dd3d_46fb_a4f7_78800006a05e();
				InternalFirst__char_32_Person__char_32_Player_id4_UnityEngine__char_46_Transform_7842236257865821986_First__char_32_Person__char_32_Player_id4_UnityEngine__char_46_Transform_7842236257865821986_position.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalFirst__char_32_Person__char_32_Player_id4_UnityEngine__char_46_Transform_7842236257865821986_First__char_32_Person__char_32_Player_id4_UnityEngine__char_46_Transform_7842236257865821986_position)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (UnityEngine.Transform).position");
			}
			if (coherenceSync.TryGetBindingByGuid("5402b0de-e341-4b2c-b26a-2d7ae7281642", "localScale", out Binding InternalFirst__char_32_Person__char_32_Player_id4_UnityEngine__char_46_Transform_7842236257865821986_First__char_32_Person__char_32_Player_id4_UnityEngine__char_46_Transform_7842236257865821986_localScale))
			{
				var clone = new Binding_5b66f4ea00578924390ab3ef8489d129_5402b0de_e341_4b2c_b26a_2d7ae7281642();
				InternalFirst__char_32_Person__char_32_Player_id4_UnityEngine__char_46_Transform_7842236257865821986_First__char_32_Person__char_32_Player_id4_UnityEngine__char_46_Transform_7842236257865821986_localScale.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalFirst__char_32_Person__char_32_Player_id4_UnityEngine__char_46_Transform_7842236257865821986_First__char_32_Person__char_32_Player_id4_UnityEngine__char_46_Transform_7842236257865821986_localScale)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (UnityEngine.Transform).localScale");
			}
			if (coherenceSync.TryGetBindingByGuid("e26b44ff-0003-47ba-8054-ffff631c3717", "rotation", out Binding InternalFirst__char_32_Person__char_32_Player_id4_UnityEngine__char_46_Transform_7842236257865821986_First__char_32_Person__char_32_Player_id4_UnityEngine__char_46_Transform_7842236257865821986_rotation))
			{
				var clone = new Binding_5b66f4ea00578924390ab3ef8489d129_e26b44ff_0003_47ba_8054_ffff631c3717();
				InternalFirst__char_32_Person__char_32_Player_id4_UnityEngine__char_46_Transform_7842236257865821986_First__char_32_Person__char_32_Player_id4_UnityEngine__char_46_Transform_7842236257865821986_rotation.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalFirst__char_32_Person__char_32_Player_id4_UnityEngine__char_46_Transform_7842236257865821986_First__char_32_Person__char_32_Player_id4_UnityEngine__char_46_Transform_7842236257865821986_rotation)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (UnityEngine.Transform).rotation");
			}
		}

		public override List<ICoherenceComponentData> CreateEntity()
		{
			if (coherenceSync.UsesLODsAtRuntime && (Archetypes.IndexForName.TryGetValue(coherenceSync.Archetype.ArchetypeName, out int archetypeIndex)))
			{
				var components = new List<ICoherenceComponentData>()
				{
					new ArchetypeComponent
					{
						index = archetypeIndex
					}
				};

				return components;
			}
			else
			{
				logger.Warning($"Unable to find archetype {coherenceSync.Archetype.ArchetypeName} in dictionary. Please, bake manually (coherence > Bake)");
			}

			return null;
		}

		public override void Initialize(CoherenceSync sync, IClient client)
		{
			if (coherenceSync == null)
			{
				coherenceSync = sync;
			}
			this.client = client;
		}

		public override void ReceiveCommand(IEntityCommand command)
		{
			switch(command)
			{
				default:
					logger.Warning($"[CoherenceSyncFirst__char_32_Person__char_32_Player_id4] Unhandled command: {command.GetType()}.");
					break;
			}
		}
	}
}