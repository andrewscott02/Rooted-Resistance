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

	public class Binding_4e2bbc787b16997458ad85cd28b6e92d_46250f23_a405_4654_acf7_af7694537664 : BoolBinding
	{
		private PlantObject CastedUnityComponent;		

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (PlantObject)UnityComponent;
		}
		public override string CoherenceComponentName => "Roots_id9_PlantObject_4095048946780906312";

		public override uint FieldMask => 0b00000000000000000000000000000001;

		public override bool Value
		{
			get => (bool)(System.Boolean)(CastedUnityComponent.enabled);
			set => CastedUnityComponent.enabled = (System.Boolean)(value);
		}

		protected override bool ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Roots_id9_PlantObject_4095048946780906312)coherenceComponent;
			return update.enabled;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Roots_id9_PlantObject_4095048946780906312)coherenceComponent;
			update.enabled = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new Roots_id9_PlantObject_4095048946780906312();
		}
	}

	public class Binding_4e2bbc787b16997458ad85cd28b6e92d_dff44d6f_21dc_4b8e_9566_82c8f0d1a8a0 : Vector3Binding
	{
		private UnityEngine.BoxCollider CastedUnityComponent;		

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (UnityEngine.BoxCollider)UnityComponent;
		}
		public override string CoherenceComponentName => "Roots_id9_UnityEngine__char_46_BoxCollider_1309972150818594054";

		public override uint FieldMask => 0b00000000000000000000000000000001;

		public override Vector3 Value
		{
			get => (Vector3)(UnityEngine.Vector3)(CastedUnityComponent.size);
			set => CastedUnityComponent.size = (UnityEngine.Vector3)(value);
		}

		protected override Vector3 ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Roots_id9_UnityEngine__char_46_BoxCollider_1309972150818594054)coherenceComponent;
			return update.size;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Roots_id9_UnityEngine__char_46_BoxCollider_1309972150818594054)coherenceComponent;
			update.size = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new Roots_id9_UnityEngine__char_46_BoxCollider_1309972150818594054();
		}
	}

	public class Binding_4e2bbc787b16997458ad85cd28b6e92d_f5563b19_1ef4_4e99_bdc2_51c43b7e5b9c : IntBinding
	{
		private Health CastedUnityComponent;		

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (Health)UnityComponent;
		}
		public override string CoherenceComponentName => "Roots_id9_Health_1707105239468578422";

		public override uint FieldMask => 0b00000000000000000000000000000001;

		public override int Value
		{
			get => (int)(System.Int32)(CastedUnityComponent.maxHealth);
			set => CastedUnityComponent.maxHealth = (System.Int32)(value);
		}

		protected override int ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Roots_id9_Health_1707105239468578422)coherenceComponent;
			return update.maxHealth;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Roots_id9_Health_1707105239468578422)coherenceComponent;
			update.maxHealth = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new Roots_id9_Health_1707105239468578422();
		}
	}

	public class Binding_4e2bbc787b16997458ad85cd28b6e92d_2ca25c80_f8c8_4984_afdf_bb8a36966040 : IntBinding
	{
		private Health CastedUnityComponent;		

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (Health)UnityComponent;
		}
		public override string CoherenceComponentName => "Roots_id9_Health_1707105239468578422";

		public override uint FieldMask => 0b00000000000000000000000000000010;

		public override int Value
		{
			get => (int)(System.Int32)(CastedUnityComponent.currentHealth);
			set => CastedUnityComponent.currentHealth = (System.Int32)(value);
		}

		protected override int ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Roots_id9_Health_1707105239468578422)coherenceComponent;
			return update.currentHealth;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Roots_id9_Health_1707105239468578422)coherenceComponent;
			update.currentHealth = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new Roots_id9_Health_1707105239468578422();
		}
	}

	public class Binding_4e2bbc787b16997458ad85cd28b6e92d_8dd557e5_ac14_41a5_9c4a_97c7541d76c1 : DeepScaleBinding
	{
		private UnityEngine.Transform CastedUnityComponent;		

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (UnityEngine.Transform)UnityComponent;
		}
		public override string CoherenceComponentName => "Roots_id9_UnityEngine__char_46_Transform_1568436447820697733";

		public override uint FieldMask => 0b00000000000000000000000000000001;

		public override Vector3 Value
		{
			get => (Vector3)(UnityEngine.Vector3)(CastedUnityComponent.localScale);
			set => CastedUnityComponent.localScale = (UnityEngine.Vector3)(value);
		}

		protected override Vector3 ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Roots_id9_UnityEngine__char_46_Transform_1568436447820697733)coherenceComponent;
			return update.localScale;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Roots_id9_UnityEngine__char_46_Transform_1568436447820697733)coherenceComponent;
			update.localScale = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new Roots_id9_UnityEngine__char_46_Transform_1568436447820697733();
		}
	}

	public class Binding_4e2bbc787b16997458ad85cd28b6e92d_e7a743e7_f562_4826_a69e_8650f08b0c41 : DeepRotationBinding
	{
		private UnityEngine.Transform CastedUnityComponent;		

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (UnityEngine.Transform)UnityComponent;
		}
		public override string CoherenceComponentName => "Roots_id9_UnityEngine__char_46_Transform_1568436447820697733";

		public override uint FieldMask => 0b00000000000000000000000000000010;

		public override Quaternion Value
		{
			get => (Quaternion)(UnityEngine.Quaternion)(CastedUnityComponent.localRotation);
			set => CastedUnityComponent.localRotation = (UnityEngine.Quaternion)(value);
		}

		protected override Quaternion ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Roots_id9_UnityEngine__char_46_Transform_1568436447820697733)coherenceComponent;
			return update.rotation;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Roots_id9_UnityEngine__char_46_Transform_1568436447820697733)coherenceComponent;
			update.rotation = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new Roots_id9_UnityEngine__char_46_Transform_1568436447820697733();
		}
	}

	public class Binding_4e2bbc787b16997458ad85cd28b6e92d_f30eda7d_cb3f_4cd1_8b9d_e4a5495ba2de : DeepPositionBinding
	{
		private UnityEngine.Transform CastedUnityComponent;		

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (UnityEngine.Transform)UnityComponent;
		}
		public override string CoherenceComponentName => "Roots_id9_UnityEngine__char_46_Transform_1568436447820697733";

		public override uint FieldMask => 0b00000000000000000000000000000100;

		public override Vector3 Value
		{
			get => (Vector3)(UnityEngine.Vector3)(CastedUnityComponent.localPosition);
			set => CastedUnityComponent.localPosition = (UnityEngine.Vector3)(value);
		}

		protected override Vector3 ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Roots_id9_UnityEngine__char_46_Transform_1568436447820697733)coherenceComponent;
			return update.position;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Roots_id9_UnityEngine__char_46_Transform_1568436447820697733)coherenceComponent;
			update.position = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new Roots_id9_UnityEngine__char_46_Transform_1568436447820697733();
		}
	}

	public class Binding_4e2bbc787b16997458ad85cd28b6e92d_9579c4b9_5fab_4e50_ad16_f0cfb8eb3019 : Vector2Binding
	{
		private UnityEngine.SpriteRenderer CastedUnityComponent;		

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (UnityEngine.SpriteRenderer)UnityComponent;
		}
		public override string CoherenceComponentName => "Roots_id9_UnityEngine__char_46_SpriteRenderer_4894113992013662324";

		public override uint FieldMask => 0b00000000000000000000000000000001;

		public override Vector2 Value
		{
			get => (Vector2)(UnityEngine.Vector2)(CastedUnityComponent.size);
			set => CastedUnityComponent.size = (UnityEngine.Vector2)(value);
		}

		protected override Vector2 ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Roots_id9_UnityEngine__char_46_SpriteRenderer_4894113992013662324)coherenceComponent;
			return update.size;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Roots_id9_UnityEngine__char_46_SpriteRenderer_4894113992013662324)coherenceComponent;
			update.size = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new Roots_id9_UnityEngine__char_46_SpriteRenderer_4894113992013662324();
		}
	}


	[Preserve]
	[AddComponentMenu("coherence/Baked/Baked 'Roots' (auto assigned)")]
	[RequireComponent(typeof(CoherenceSync))]
	public class CoherenceSyncRoots_id9 : CoherenceSyncBaked
	{
		private CoherenceSync coherenceSync;
		private Logger logger;

		// Cached targets for commands
		private InputBuffer<Roots> inputBuffer;
		private Roots currentInput;
		private long lastAddedFrame = -1;
		private CoherenceInput coherenceInput;
		private long currentSimulationFrame => coherenceInput.CurrentSimulationFrame;

		private IClient client;
		private CoherenceMonoBridge monoBridge => coherenceSync.MonoBridge;

		protected void Awake()
		{
			coherenceSync = GetComponent<CoherenceSync>();
			coherenceSync.usingReflection = false;

			logger = coherenceSync.logger.With<CoherenceSyncRoots_id9>();
			coherenceInput = coherenceSync.Input;
			inputBuffer = new InputBuffer<Roots>(coherenceInput.InitialBufferSize, coherenceInput.InitialBufferDelay, coherenceInput.UseFixedSimulationFrames);
			if (coherenceSync.TryGetBindingByGuid("46250f23-a405-4654-acf7-af7694537664", "enabled", out Binding InternalRoots_id9_PlantObject_4095048946780906312_Roots_id9_PlantObject_4095048946780906312_enabled))
			{
				var clone = new Binding_4e2bbc787b16997458ad85cd28b6e92d_46250f23_a405_4654_acf7_af7694537664();
				InternalRoots_id9_PlantObject_4095048946780906312_Roots_id9_PlantObject_4095048946780906312_enabled.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalRoots_id9_PlantObject_4095048946780906312_Roots_id9_PlantObject_4095048946780906312_enabled)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (PlantObject).enabled");
			}
			if (coherenceSync.TryGetBindingByGuid("dff44d6f-21dc-4b8e-9566-82c8f0d1a8a0", "size", out Binding InternalRoots_id9_UnityEngine__char_46_BoxCollider_1309972150818594054_Roots_id9_UnityEngine__char_46_BoxCollider_1309972150818594054_size))
			{
				var clone = new Binding_4e2bbc787b16997458ad85cd28b6e92d_dff44d6f_21dc_4b8e_9566_82c8f0d1a8a0();
				InternalRoots_id9_UnityEngine__char_46_BoxCollider_1309972150818594054_Roots_id9_UnityEngine__char_46_BoxCollider_1309972150818594054_size.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalRoots_id9_UnityEngine__char_46_BoxCollider_1309972150818594054_Roots_id9_UnityEngine__char_46_BoxCollider_1309972150818594054_size)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (UnityEngine.BoxCollider).size");
			}
			if (coherenceSync.TryGetBindingByGuid("f5563b19-1ef4-4e99-bdc2-51c43b7e5b9c", "maxHealth", out Binding InternalRoots_id9_Health_1707105239468578422_Roots_id9_Health_1707105239468578422_maxHealth))
			{
				var clone = new Binding_4e2bbc787b16997458ad85cd28b6e92d_f5563b19_1ef4_4e99_bdc2_51c43b7e5b9c();
				InternalRoots_id9_Health_1707105239468578422_Roots_id9_Health_1707105239468578422_maxHealth.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalRoots_id9_Health_1707105239468578422_Roots_id9_Health_1707105239468578422_maxHealth)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (Health).maxHealth");
			}
			if (coherenceSync.TryGetBindingByGuid("2ca25c80-f8c8-4984-afdf-bb8a36966040", "currentHealth", out Binding InternalRoots_id9_Health_1707105239468578422_Roots_id9_Health_1707105239468578422_currentHealth))
			{
				var clone = new Binding_4e2bbc787b16997458ad85cd28b6e92d_2ca25c80_f8c8_4984_afdf_bb8a36966040();
				InternalRoots_id9_Health_1707105239468578422_Roots_id9_Health_1707105239468578422_currentHealth.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalRoots_id9_Health_1707105239468578422_Roots_id9_Health_1707105239468578422_currentHealth)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (Health).currentHealth");
			}
			if (coherenceSync.TryGetBindingByGuid("8dd557e5-ac14-41a5-9c4a-97c7541d76c1", "localScale", out Binding InternalRoots_id9_UnityEngine__char_46_Transform_1568436447820697733_Roots_id9_UnityEngine__char_46_Transform_1568436447820697733_localScale))
			{
				var clone = new Binding_4e2bbc787b16997458ad85cd28b6e92d_8dd557e5_ac14_41a5_9c4a_97c7541d76c1();
				InternalRoots_id9_UnityEngine__char_46_Transform_1568436447820697733_Roots_id9_UnityEngine__char_46_Transform_1568436447820697733_localScale.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalRoots_id9_UnityEngine__char_46_Transform_1568436447820697733_Roots_id9_UnityEngine__char_46_Transform_1568436447820697733_localScale)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (UnityEngine.Transform).localScale");
			}
			if (coherenceSync.TryGetBindingByGuid("e7a743e7-f562-4826-a69e-8650f08b0c41", "rotation", out Binding InternalRoots_id9_UnityEngine__char_46_Transform_1568436447820697733_Roots_id9_UnityEngine__char_46_Transform_1568436447820697733_rotation))
			{
				var clone = new Binding_4e2bbc787b16997458ad85cd28b6e92d_e7a743e7_f562_4826_a69e_8650f08b0c41();
				InternalRoots_id9_UnityEngine__char_46_Transform_1568436447820697733_Roots_id9_UnityEngine__char_46_Transform_1568436447820697733_rotation.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalRoots_id9_UnityEngine__char_46_Transform_1568436447820697733_Roots_id9_UnityEngine__char_46_Transform_1568436447820697733_rotation)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (UnityEngine.Transform).rotation");
			}
			if (coherenceSync.TryGetBindingByGuid("f30eda7d-cb3f-4cd1-8b9d-e4a5495ba2de", "position", out Binding InternalRoots_id9_UnityEngine__char_46_Transform_1568436447820697733_Roots_id9_UnityEngine__char_46_Transform_1568436447820697733_position))
			{
				var clone = new Binding_4e2bbc787b16997458ad85cd28b6e92d_f30eda7d_cb3f_4cd1_8b9d_e4a5495ba2de();
				InternalRoots_id9_UnityEngine__char_46_Transform_1568436447820697733_Roots_id9_UnityEngine__char_46_Transform_1568436447820697733_position.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalRoots_id9_UnityEngine__char_46_Transform_1568436447820697733_Roots_id9_UnityEngine__char_46_Transform_1568436447820697733_position)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (UnityEngine.Transform).position");
			}
			if (coherenceSync.TryGetBindingByGuid("9579c4b9-5fab-4e50-ad16-f0cfb8eb3019", "size", out Binding InternalRoots_id9_UnityEngine__char_46_SpriteRenderer_4894113992013662324_Roots_id9_UnityEngine__char_46_SpriteRenderer_4894113992013662324_size))
			{
				var clone = new Binding_4e2bbc787b16997458ad85cd28b6e92d_9579c4b9_5fab_4e50_ad16_f0cfb8eb3019();
				InternalRoots_id9_UnityEngine__char_46_SpriteRenderer_4894113992013662324_Roots_id9_UnityEngine__char_46_SpriteRenderer_4894113992013662324_size.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalRoots_id9_UnityEngine__char_46_SpriteRenderer_4894113992013662324_Roots_id9_UnityEngine__char_46_SpriteRenderer_4894113992013662324_size)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (UnityEngine.SpriteRenderer).size");
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
		private void OnDestroy()
		{
			if (monoBridge != null)
			{
				monoBridge.OnLateFixedNetworkUpdate -= SendInputState;
			}
		}

		public override void Initialize(CoherenceSync sync, IClient client)
		{
			if (coherenceSync == null)
			{
				coherenceSync = sync;
			}
			this.client = client;
			sync.Input.internalSetButtonState = SetButtonState;
			sync.Input.internalSetButtonRangeState = SetButtonRangeState;
			sync.Input.internalSetAxisState = SetAxisState;
			sync.Input.internalSetStringState = SetStringState;
			sync.Input.internalGetButtonState = GetButtonState;
			sync.Input.internalGetButtonRangeState = GetButtonRangeState;
			sync.Input.internalGetAxisState = GetAxisState;
			sync.Input.internalGetStringState = GetStringState;
			sync.Input.internalRequestBuffer = () => inputBuffer;
			sync.Input.internalOnInputReceived += OnInput;
			sync.Input.internalRequestBuffer = () => inputBuffer;

			if (coherenceInput.UseFixedSimulationFrames)
			{
				sync.MonoBridge.OnLateFixedNetworkUpdate += SendInputState;
			}
		}

		public override void ReceiveCommand(IEntityCommand command)
		{
			switch(command)
			{
				default:
					logger.Warning($"[CoherenceSyncRoots_id9] Unhandled command: {command.GetType()}.");
					break;
			}
		}

		private void SetButtonState(string name, bool value)
		{
			switch(name)
			{
				default:
					logger.Error($"No input button of name: {name}");
					break;
			}
		}

		private void SetButtonRangeState(string name, float value)
		{
			switch(name)
			{
			default:
				logger.Error($"No input button range of name: {name}");
				break;
			}
		}

		private void SetAxisState(string name, Vector2 value)
		{
			switch(name)
			{
			default:
				logger.Error($"No input axis of name: {name}");
				break;
			}
		}

		private void SetStringState(string name, string value)
		{
			switch(name)
			{
				default:
					logger.Error($"No input button of name: {name}");
					break;
			}
		}

		public override void SendInputState()
		{
			if (!coherenceInput.IsProducer || !coherenceInput.IsReadyToProcessInputs || !coherenceInput.IsInputOwner)
			{
				return;
			}

			if (lastAddedFrame != currentSimulationFrame)
			{
				inputBuffer.AddInput(currentInput, currentSimulationFrame);
				lastAddedFrame = currentSimulationFrame;
			}

			while (inputBuffer.DequeueForSending(currentSimulationFrame, out long frameToSend, out Roots input, out bool differs))
			{
				coherenceInput.DebugOnInputSent(frameToSend, input);
				client.SendInput(input, frameToSend, coherenceSync.EntityID);
			}
		}

		private bool ShouldPollCurrentInput(long frame)
		{
			return coherenceInput.IsProducer && coherenceInput.Delay == 0 && frame == currentSimulationFrame;
		}

		private bool GetButtonState(string name, long? simulationFrame)
		{
			long frame = simulationFrame.GetValueOrDefault(currentSimulationFrame);

			switch(name)
			{
				default:
					logger.Error($"No input button of name: {name}");
					break;
			}

			return false;
		}

		private float GetButtonRangeState(string name, long? simulationFrame)
		{
			long frame = simulationFrame.GetValueOrDefault(currentSimulationFrame);

			switch(name)
			{
			default:
				logger.Error($"No input button range of name: {name}");
				break;
			}

			return 0f;
		}

		private Vector2 GetAxisState(string name, long? simulationFrame)
		{
			long frame = simulationFrame.GetValueOrDefault(currentSimulationFrame);

			switch(name)
			{
			default:
				logger.Error($"No input axis of name: {name}");
				break;
			}

			return Vector2.zero;
		}

		private string GetStringState(string name, long? simulationFrame)
		{
			long frame = simulationFrame.GetValueOrDefault(currentSimulationFrame);

			switch(name)
			{
				default:
					logger.Error($"No input button of name: {name}");
					break;
			}

			return null;
		}

		private void OnInput(IEntityInput entityInput, long frame)
		{
			var input = (Roots)entityInput;
			coherenceInput.DebugOnInputReceived(frame, entityInput);
			inputBuffer.ReceiveInput(input, frame);
		}
	}
}
