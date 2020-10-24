using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using System.Management;
using System.Collections.ObjectModel;
using System.Management.Automation.Runspaces;

namespace PipelineCommanderForms
{
    public class PipelineCommands
    {
        /// <summary>
        /// Getting device Serial Number
        /// </summary>
        /// <returns></returns>
        public string GetSerialNumber()
        {
            ManagementObjectSearcher _search = new ManagementObjectSearcher("select SerialNumber from Win32_BaseBoard");

            ManagementObjectCollection _info = _search.Get();
            string _serialProperty = "";

            foreach(ManagementObject obj in _info)
            {
                foreach(PropertyData _serialnumber in obj.Properties)
                {
                    _serialProperty =  string.Join(" ", "Product serial number: ", _serialnumber.Value);
                }
            }
            _search.Dispose();

            return _serialProperty;
        }

        /// <summary>
        /// Getting device Model
        /// </summary>
        /// <returns></returns>
        public string GetModel()
        {
            ManagementObjectSearcher _search = new ManagementObjectSearcher("select Model from Win32_BaseBoard");

            ManagementObjectCollection _modelInfo = _search.Get();
            string _modelProperty = "";

            foreach(ManagementObject obj in _modelInfo)
            {
                foreach(PropertyData _model in obj.Properties)
                {
                    _modelProperty = string.Join(" ", "Product model: ", _model.Value);
                }
            }
            _search.Dispose();

            return _modelProperty;
        }

        /// <summary>
        /// Getting device Name
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            ManagementObjectSearcher _search = new ManagementObjectSearcher("select Name from Win32_BaseBoard");

            ManagementObjectCollection _nameInfo = _search.Get();
            string _nameProperty = "";

            foreach (ManagementObject obj in _nameInfo)
            {
                foreach (PropertyData _name in obj.Properties)
                {
                    _nameProperty = string.Join(" ", "Product model: ", _name.Value);
                }
            }
            _search.Dispose();

            return _nameProperty;
        }

        /// <summary>
        /// Getting Manufacturer
        /// </summary>
        /// <returns></returns>
        public string GetManufacturer()
        {
            ManagementObjectSearcher _search = new ManagementObjectSearcher("select Model from Win32_BaseBoard");

            ManagementObjectCollection _manufacturerInfo = _search.Get();
            string _manufacturerProperty = "";

            foreach (ManagementObject obj in _manufacturerInfo)
            {
                foreach (PropertyData _manufacturer in obj.Properties)
                {
                    _manufacturerProperty = string.Join(" ", "Product model: ", _manufacturer.Value);
                }
            }
            _search.Dispose();

            return _manufacturerProperty;
        }
    }
}
