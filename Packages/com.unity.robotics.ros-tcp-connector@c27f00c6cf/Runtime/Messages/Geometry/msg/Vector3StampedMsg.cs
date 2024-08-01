//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Geometry
{
    [Serializable]
    public class Vector3StampedMsg : Message
    {
        public const string k_RosMessageName = "geometry_msgs/Vector3Stamped";
        public override string RosMessageName => k_RosMessageName;

        //  This represents a Vector3 with reference coordinate frame and timestamp
        //  Note that this follows vector semantics with it always anchored at the origin,
        //  so the rotational elements of a transform are the only parts applied when transforming.
        public Std.HeaderMsg header;
        public Vector3Msg vector;

        public Vector3StampedMsg()
        {
            this.header = new Std.HeaderMsg();
            this.vector = new Vector3Msg();
        }

        public Vector3StampedMsg(Std.HeaderMsg header, Vector3Msg vector)
        {
            this.header = header;
            this.vector = vector;
        }

        public static Vector3StampedMsg Deserialize(MessageDeserializer deserializer) => new Vector3StampedMsg(deserializer);

        private Vector3StampedMsg(MessageDeserializer deserializer)
        {
            this.header = Std.HeaderMsg.Deserialize(deserializer);
            this.vector = Vector3Msg.Deserialize(deserializer);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.header);
            serializer.Write(this.vector);
        }

        public override string ToString()
        {
            return "Vector3StampedMsg: " +
            "\nheader: " + header.ToString() +
            "\nvector: " + vector.ToString();
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
