using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using System.Management;
using System.Collections.ObjectModel;
using System.Management.Automation.Runspaces;

namespace PipelineCommanderForms.libs
{
    public class PipelineCommands
    {
        /// <summary>
        /// Get device Serial Number
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
                    _serialProperty =  string.Join(" ",  _serialnumber.Value);
                }
            }
            _search.Dispose();

            return _serialProperty;
        }

        /// <summary>
        /// Get device Name
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
                    _nameProperty = string.Join(" ", _name.Value);
                }
            }
            _search.Dispose();

            return _nameProperty;
        }

        /// <summary>
        /// Get Manufacturer
        /// </summary>
        /// <returns></returns>
        public string GetManufacturer()
        {
            ManagementObjectSearcher _search = new ManagementObjectSearcher("select Manufacturer from Win32_BaseBoard");

            ManagementObjectCollection _manufacturerInfo = _search.Get();
            string _manufacturerProperty = "";

            foreach (ManagementObject obj in _manufacturerInfo)
            {
                foreach (PropertyData _manufacturer in obj.Properties)
                {
                    _manufacturerProperty = string.Join(" ", _manufacturer.Value);
                }
            }
            _search.Dispose();

            return _manufacturerProperty;
        }

        /// <summary>
        /// Get status
        /// </summary>
        /// <returns></returns>
        public string GetStatus()
        {
            ManagementObjectSearcher _search = new ManagementObjectSearcher("select Status from Win32_BIOS");

            ManagementObjectCollection _statusInfo = _search.Get();
            string _statusproperty = "";

            foreach (ManagementObject obj in _statusInfo)
            {
                foreach (PropertyData _status in obj.Properties)
                {
                    _statusproperty = string.Join(" ", _status.Value);
                }
            }
            _search.Dispose();

            return _statusproperty;
        }

        /// <summary>
        /// Get version
        /// </summary>
        /// <returns></returns>
        public string GetVersion()
        {
            ManagementObjectSearcher _search = new ManagementObjectSearcher("select Version from Win32_BIOS");

            ManagementObjectCollection _version = _search.Get();
            string __versionProperty = "";

            foreach (ManagementObject obj in _version)
            {
                foreach (PropertyData _ver in obj.Properties)
                {
                    __versionProperty = string.Join(" ", _ver.Value);
                }
            }
            _search.Dispose();

            return __versionProperty;
        }
    }
}
