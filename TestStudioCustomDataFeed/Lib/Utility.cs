using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Core;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Reflection;

namespace TestStudioCustomDataFeed
{
    public static class Utility
    {
        private static string RootFolder
        {
            get
            {
                return Path.GetDirectoryName(Assembly.GetAssembly(typeof(Utility)).Location);
            }
        }
        /// <summary>
        /// Finds the json file by relative path and loads a JArray from its contents. 
        /// Returns null if the array could not successfully retrieved.
        /// </summary>
        /// <param name="relativePath">Path to the JSON file relative to the root.</param>
        /// <returns>A JArray populated from the contents of the json file.</returns>
        public static JArray GetJSONArrayFromFile(string relativePath)
        {
            try
            {
                return JArray.Parse(GetFileContents(relativePath));
            }
            catch (FileNotFoundException e)
            {
                throw e;
            }
            catch (DirectoryNotFoundException e)
            {
                throw e;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Finds the json file by relative path and loads a JObject from its contents. 
        /// </summary>
        /// <param name="relativePath">Path to the JSON file relative to the root.</param>
        /// <returns>A JObject populated from the contents of the json file.</returns>
        public static JObject GetJSONObjectFromFile(string relativePath)
        {
            try
            {
                return JObject.Parse(GetFileContents(relativePath));
            }
            catch (FileNotFoundException e)
            {
                throw e;
            }
            catch (DirectoryNotFoundException e)
            {
                throw e;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Gets the text contents of a file.
        /// </summary>
        /// <param name="relativePath">Path to the file relative to the root.</param>
        /// <returns>String containing the text form the file.</returns>
        public static string GetFileContents(string relativePath)
        {
            string fileContents = string.Empty;

            using (StreamReader reader = File.OpenText(Path.Combine(RootFolder, relativePath)))
            {
                fileContents = reader.ReadToEnd();
            }

            return fileContents;
        }

        /// <summary>
        /// Finds a JObject member of a JObject by key (extension method).
        /// </summary>
        /// <param name="json">JObject instance.</param>
        /// <param name="key">Key.</param>
        /// <returns>Returns the found member if it is JObject, otherwise returns null.</returns>
        public static JObject GetJObject(this JObject json, string key)
        {
            var value = json.GetValue(key);
            if (value != null && value is JObject) return (JObject)value;
            else return null;
        }

        /// <summary>
        /// Finds a member of a JObject by key and parses it into string (extension method).
        /// </summary>
        /// <param name="json">JObject instance.</param>
        /// <param name="key">Key.</param>
        /// <returns>If a member is found returns member.ToString(), otherwise returns null.</returns>
        public static string GetString(this JObject json, string key)
        {
            var value = json.GetValue(key);
            if (value != null) return value.ToString();
            else return null;
        }

        /// <summary>
        /// Finds a member of a JObject by key and parses it into boolean (extension method).
        /// </summary>
        /// <param name="json">JObject instance.</param>
        /// <param name="key">Key.</param>
        /// <returns>Returns the found member if it is boolean, otherwise returns null.</returns>
        public static bool? GetBoolean(this JObject json, string key)
        {
            var value = json.GetValue(key);
            try
            {
                if (value != null && value is JValue)
                    return ((JValue)value).Value<bool?>();
            }
            catch (Exception) { }

            return null;
        }

        /// <summary>
        /// Parses string as JObject (extension method).
        /// </summary>
        /// <param name="toParse">String to be parsed.</param>
        /// <returns>The JObject if the string contains one, otherwise null.</returns>
        public static JObject AsJObject(this string toParse)
        {
            try
            {
                return JObject.Parse(toParse);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Parses string as JArray (extension method).
        /// </summary>
        /// <param name="toParse">String to be parsed.</param>
        /// <returns>The JArray if the string contains one, otherwise null.</returns>
        public static JArray AsJArray(this string toParse)
        {
            try
            {
                return JArray.Parse(toParse);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Add a string key / value pair to the given JObject (extension method).
        /// </summary>
        /// <param name="json">JObject to be used.</param>
        /// <param name="key">Key.</param>
        /// <param name="value">Value.</param>
        public static void AddString(this JObject json, string key, string value)
        {
            json.Add(key, new JValue(value));
        }

        public static JObject GetJObject(this JArray jsonArray, int index)
        {
            if (index <= jsonArray.Count)
            {
                return (JObject)jsonArray[index];
            }

            return null;
        }

        public static void SetInputText(this HtmlControl element, string text)
        {
            string script =
                "angular.element(" + element.ClientSideLocator + ").val('" + text + "').trigger('input')";
            Manager.Current.ActiveBrowser.Actions.InvokeScript(script);
        }
    }
}
