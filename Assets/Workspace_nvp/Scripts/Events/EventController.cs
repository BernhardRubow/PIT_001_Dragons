using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using Object = System.Object;

namespace nvp.Events
{
    
    public class EventController
    {
        // +++ fields +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private static readonly Dictionary<string, List<Action<object, object>>> _eventHandler;




        // +++ static constructor (called on first use of any method ++++++++++++++++++++++++++++++
        static EventController()
        {
            _eventHandler = new Dictionary<string, List<Action<object, object>>>();
        }




        // +++ static class methods +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public static void SubscribeEvent(string eventName, System.Action<object, object> callback)
        {
            if (!_eventHandler.ContainsKey(eventName))
            {
                _eventHandler[eventName] = new List<Action<object, object>>();
            }

            _eventHandler[eventName].Add(callback);
        }

        public static void UnsubscribeEvent(string eventName, System.Action<object, object> callback)
        {
            if (!_eventHandler.ContainsKey(eventName))
            {
                Debug.LogWarningFormat("Unsubscribe faild. {0} not registered as Event.", eventName);
                return;
            }

            _eventHandler[eventName].Remove(callback);
        }

        public static void InvokeEvent(string eventName, object sender, object args)
        {
            if (!_eventHandler.ContainsKey(eventName))
            {
                Debug.LogWarningFormat("Unsubscribe faild. {0} not registered as Event.", eventName);
                return;
            }

            foreach(var callback in _eventHandler[eventName])
            {
                callback(sender, args);
            }
        }
    }
}
