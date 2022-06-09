//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Visualization
{
    [Serializable]
    public class InteractiveMarkerFeedbackMsg : Message
    {
        public const string k_RosMessageName = "visualization_msgs/InteractiveMarkerFeedback";
        public override string RosMessageName => k_RosMessageName;

        //  Time/frame info.
        public Std.HeaderMsg header;
        //  Identifying string. Must be unique in the topic namespace.
        public string client_id;
        //  Feedback message sent back from the GUI, e.g.
        //  when the status of an interactive marker was modified by the user.
        //  Specifies which interactive marker and control this message refers to
        public string marker_name;
        public string control_name;
        //  Type of the event
        //  KEEP_ALIVE: sent while dragging to keep up control of the marker
        //  MENU_SELECT: a menu entry has been selected
        //  BUTTON_CLICK: a button control has been clicked
        //  POSE_UPDATE: the pose has been changed using one of the controls
        public const byte KEEP_ALIVE = 0;
        public const byte POSE_UPDATE = 1;
        public const byte MENU_SELECT = 2;
        public const byte BUTTON_CLICK = 3;
        public const byte MOUSE_DOWN = 4;
        public const byte MOUSE_UP = 5;
        public byte event_type;
        //  Current pose of the marker
        //  Note: Has to be valid for all feedback types.
        public Geometry.PoseMsg pose;
        //  Contains the ID of the selected menu entry
        //  Only valid for MENU_SELECT events.
        public uint menu_entry_id;
        //  If event_type is BUTTON_CLICK, MOUSE_DOWN, or MOUSE_UP, mouse_point
        //  may contain the 3 dimensional position of the event on the
        //  control.  If it does, mouse_point_valid will be true.  mouse_point
        //  will be relative to the frame listed in the header.
        public Geometry.PointMsg mouse_point;
        public bool mouse_point_valid;

        public InteractiveMarkerFeedbackMsg()
        {
            this.header = new Std.HeaderMsg();
            this.client_id = "";
            this.marker_name = "";
            this.control_name = "";
            this.event_type = 0;
            this.pose = new Geometry.PoseMsg();
            this.menu_entry_id = 0;
            this.mouse_point = new Geometry.PointMsg();
            this.mouse_point_valid = false;
        }

        public InteractiveMarkerFeedbackMsg(Std.HeaderMsg header, string client_id, string marker_name, string control_name, byte event_type, Geometry.PoseMsg pose, uint menu_entry_id, Geometry.PointMsg mouse_point, bool mouse_point_valid)
        {
            this.header = header;
            this.client_id = client_id;
            this.marker_name = marker_name;
            this.control_name = control_name;
            this.event_type = event_type;
            this.pose = pose;
            this.menu_entry_id = menu_entry_id;
            this.mouse_point = mouse_point;
            this.mouse_point_valid = mouse_point_valid;
        }

        public static InteractiveMarkerFeedbackMsg Deserialize(MessageDeserializer deserializer) => new InteractiveMarkerFeedbackMsg(deserializer);

        private InteractiveMarkerFeedbackMsg(MessageDeserializer deserializer)
        {
            this.header = Std.HeaderMsg.Deserialize(deserializer);
            deserializer.Read(out this.client_id);
            deserializer.Read(out this.marker_name);
            deserializer.Read(out this.control_name);
            deserializer.Read(out this.event_type);
            this.pose = Geometry.PoseMsg.Deserialize(deserializer);
            deserializer.Read(out this.menu_entry_id);
            this.mouse_point = Geometry.PointMsg.Deserialize(deserializer);
            deserializer.Read(out this.mouse_point_valid);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.header);
            serializer.Write(this.client_id);
            serializer.Write(this.marker_name);
            serializer.Write(this.control_name);
            serializer.Write(this.event_type);
            serializer.Write(this.pose);
            serializer.Write(this.menu_entry_id);
            serializer.Write(this.mouse_point);
            serializer.Write(this.mouse_point_valid);
        }

        public override string ToString()
        {
            return "InteractiveMarkerFeedbackMsg: " +
            "\nheader: " + header.ToString() +
            "\nclient_id: " + client_id.ToString() +
            "\nmarker_name: " + marker_name.ToString() +
            "\ncontrol_name: " + control_name.ToString() +
            "\nevent_type: " + event_type.ToString() +
            "\npose: " + pose.ToString() +
            "\nmenu_entry_id: " + menu_entry_id.ToString() +
            "\nmouse_point: " + mouse_point.ToString() +
            "\nmouse_point_valid: " + mouse_point_valid.ToString();
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
