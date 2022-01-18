//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Spot
{
    [Serializable]
    public class ListGraphResponse : Message
    {
        public const string k_RosMessageName = "spot_msgs/ListGraph";
        public override string RosMessageName => k_RosMessageName;

        public string[] waypoint_ids;

        public ListGraphResponse()
        {
            this.waypoint_ids = new string[0];
        }

        public ListGraphResponse(string[] waypoint_ids)
        {
            this.waypoint_ids = waypoint_ids;
        }

        public static ListGraphResponse Deserialize(MessageDeserializer deserializer) => new ListGraphResponse(deserializer);

        private ListGraphResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.waypoint_ids, deserializer.ReadLength());
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.WriteLength(this.waypoint_ids);
            serializer.Write(this.waypoint_ids);
        }

        public override string ToString()
        {
            return "ListGraphResponse: " +
            "\nwaypoint_ids: " + System.String.Join(", ", waypoint_ids.ToList());
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize);
        }
    }
}
