using UnityEngine;
using System;

namespace Utility{
  class GDebug{
		static bool DEBUGMODE = true;

    /// <summary>
	  /// Logs a message to the Unity Console if debug mode is enabled.
	  /// </summary>
	  /// <param name="message"> String or object to be converted to string representation for display.</param>
		public static void Log(string message){
			if (DEBUGMODE)
			{
				Debug.Log(message);
			}
		}

		/// <summary>
	  /// Logs a message to the Unity Console if debug mode is enabled.
		/// </summary>
		/// <param name="message"> String or object to be converted to string representation for display.</param>
		/// <param name="obj">Object to which the message applies.</param>
    public static void Log(string message, UnityEngine.Object obj){
      if(DEBUGMODE){
        Debug.Log(message, obj);
      }
    }

    /// <summary>
    /// Logs a message to the Unity Console if debug mode is enabled.
    /// </summary>
    /// <param name="message">String or object to be converted to string representation for display.</param>
    /// <param name="className">Name of object who sent the message log.</param>
    /// <param name="functionName">Name of function who sent the message log.</param>
		public static void Log(string message, string className, string functionName)
		{
			if (DEBUGMODE)
			{
				Debug.Log(className + "::" + functionName + "() // " + message);
			}
		}

    /// <summary>
	  /// Logs a message to the Unity Console if debug mode is enabled
	  /// </summary>
	  /// <param name="message">String or object to be converted to string representation for display.</param>
	  /// <param name="classObject">Object who sent the message log.</param>
	  /// <param name="functionName">Name of Function who sent the message log.</param>
    public static void Log(string message, UnityEngine.Object classObject, string functionName){
      if(DEBUGMODE){
				Debug.Log(classObject.GetType().Name + "::" + functionName + "() // " + message);
			}
    }

    /// <summary>
	  /// Logs an error message to the Unity Console if debug mode is enabled.
	  /// </summary>
	  /// <param name="message"> String or object to be converted to string representation for display.</param>
    public static void LogError(string message){
      if(DEBUGMODE){
        Debug.LogError(message);
      }
    }

		/// <summary>
	  /// Logs an error message to the Unity Console if debug mode is enabled.
		/// </summary>
		/// <param name="message"> String or object to be converted to string representation for display.</param>
		/// <param name="obj">Object to which the message applies.</param>
    public static void LogError(string message, UnityEngine.Object obj){
      if(DEBUGMODE){
				Debug.LogError(message, obj);
			}
    }
    /// <summary>
	  /// Logs an Error message to the Unity Console if debug mode is enabled
	  /// </summary>
	  /// <param name="message">String or object to be converted to string representation for display.</param>
	  /// <param name="classObject">Object who sent the message log.</param>
	  /// <param name="functionName">Name of Function who sent the message log.</param>
    public static void LogError(string message, UnityEngine.Object classObject, string functionName){
      if(DEBUGMODE){
				Debug.LogError(classObject.GetType().Name + "::" + functionName + "() // " + message);
			}
    }

    /// <summary>
    /// Logs an error message to the Unity Console if debug mode is enabled.
    /// </summary>
    /// <param name="message">String or object to be converted to string representation for display.</param>
    /// <param name="className">Name of object who sent the message log.</param>
    /// <param name="functionName">Name of function who sent the message log.</param>
    public static void LogError(string message, string className, string functionName){
      if(DEBUGMODE){
        Debug.LogError(className + "::" + functionName + "() // " + message) ;
      }
    }

    /// <summary>
    /// Logs a warning message to the Unity Console if debug mode is enabled.
    /// </summary>
    /// <param name="message">String or object to be converted to string representation for display.</param>
    /// <param name="className">Name of object who sent the message log.</param>
    /// <param name="functionName">Name of function who sent the message log.</param>
    public static void LogWarning(string message){
      if(DEBUGMODE){
				Debug.LogWarning(message);
			}
    }

		/// <summary>
	  /// Logs a warning message to the Unity Console if debug mode is enabled.
		/// </summary>
		/// <param name="message"> String or object to be converted to string representation for display.</param>
		/// <param name="obj">Object to which the message applies.</param>
    public static void LogWarning(string message, UnityEngine.Object obj){
      if(DEBUGMODE){
				Debug.LogWarning(message, obj);
			}
    }

    /// <summary>
	  /// Logs a warning message to the Unity Console if debug mode is enabled
	  /// </summary>
	  /// <param name="message">String or object to be converted to string representation for display.</param>
	  /// <param name="classObject">Object who sent the message log.</param>
	  /// <param name="functionName">Name of Function who sent the message log.</param>
    public static void LogWarning(string message, UnityEngine.Object classObject, string functionName){
      if(DEBUGMODE){
				Debug.LogWarning(classObject.GetType().Name + "::" + functionName + "() // " + message);
			}
    }

    /// <summary>
    /// Logs a warning message to the Unity Console if debug mode is enabled.
    /// </summary>
    /// <param name="message">String or object to be converted to string representation for display.</param>
    /// <param name="className">Name of object who sent the message log.</param>
    /// <param name="functionName">Name of function who sent the message log.</param>
    public static void LogWarning(string message, string className, string functionName){
      if(DEBUGMODE){
				Debug.LogWarning(className + "::" + functionName + "() // " + message);
			}
    }

    #region VisualGizmos
    public static void DrawRay(Vector3 start, Vector3 dir, Color color){
      if(DEBUGMODE){
        Debug.DrawRay(start, dir, color);
      }
    }
    #endregion
  }
}