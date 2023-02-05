// Copyright (c) coherence ApS.
// For all coherence generated code, the coherence SDK license terms apply. See the license file in the coherence Package root folder for more information.

// <auto-generated>
// Generated file. DO NOT EDIT!
// </auto-generated>
namespace Coherence.Generated
{
	using Coherence.ProtocolDef;
	using Coherence.Serializer;
	using Coherence.SimulationFrame;
	using Coherence.Entity;
	using Coherence.Utils;
	using Coherence.Brook;
	using Coherence.Toolkit;
	using UnityEngine;

	public struct Plant_id6_PlantObject_4428920011090734227 : ICoherenceComponentData
	{
		public bool enabled;

		public override string ToString()
		{
			return $"Plant_id6_PlantObject_4428920011090734227(enabled: {enabled})";
		}

		public uint GetComponentType() => Definition.InternalPlant_id6_PlantObject_4428920011090734227;

		public const int order = 0;

		public int GetComponentOrder() => order;

		public AbsoluteSimulationFrame Frame;
	

		public void SetSimulationFrame(AbsoluteSimulationFrame frame)
		{
			Frame = frame;
		}

		public AbsoluteSimulationFrame GetSimulationFrame() => Frame;

		public ICoherenceComponentData MergeWith(ICoherenceComponentData data, uint mask)
		{
			var other = (Plant_id6_PlantObject_4428920011090734227)data;
			if ((mask & 0x01) != 0)
			{
				Frame = other.Frame;
				enabled = other.enabled;
			}
			mask >>= 1;
			return this;
		}

		public static void Serialize(Plant_id6_PlantObject_4428920011090734227 data, uint mask, IOutProtocolBitStream bitStream)
		{
			if (bitStream.WriteMask((mask & 0x01) != 0))
			{
				bitStream.WriteBool(data.enabled);
			}
			mask >>= 1;
		}

		public static (Plant_id6_PlantObject_4428920011090734227, uint, uint?) Deserialize(InProtocolBitStream bitStream)
		{
			var mask = (uint)0;
			var val = new Plant_id6_PlantObject_4428920011090734227();
	
			if (bitStream.ReadMask())
			{
				val.enabled = bitStream.ReadBool();
				mask |= 0b00000000000000000000000000000001;
			}
			return (val, mask, null);
		}
		public static (Plant_id6_PlantObject_4428920011090734227, uint, uint?) DeserializeArchetypePlant_d765de643a6a3a84481a9718beb599b3_Plant_id6_PlantObject_4428920011090734227_LOD0(InProtocolBitStream bitStream)
		{
			var mask = (uint)0;
			var val = new Plant_id6_PlantObject_4428920011090734227();
			if (bitStream.ReadMask())
			{
				val.enabled = bitStream.ReadBool();
				mask |= 0b00000000000000000000000000000001;
			}

			return (val, mask, 0);
		}

		/// <summary>
		/// Resets byte array references to the local array instance that is kept in the lastSentData.
		/// If the array content has changed but remains of same length, the new content is copied into the local array instance.
		/// If the array length has changed, the array is cloned and overwrites the local instance.
		/// If the array has not changed, the reference is reset to the local array instance.
		/// Otherwise, changes to other fields on the component might cause the local array instance reference to become permanently lost.
		/// </summary>
		public void ResetByteArrays(ICoherenceComponentData lastSent, uint mask)
		{
			var last = lastSent as Plant_id6_PlantObject_4428920011090734227?;
	
		}
	}
}