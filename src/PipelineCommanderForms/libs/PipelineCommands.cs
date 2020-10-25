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
                    _serialProperty =  string.Join(" ", "Serial number: ", _serialnumber.Value);
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
                    _modelProperty = string.Join(" ", "Model: ", _model.Value);
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
                    _nameProperty = string.Join(" ", "Name: ", _name.Value);
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
            ManagementObjectSearcher _search = new ManagementObjectSearcher("select Manufacturer from Win32_BaseBoard");

            ManagementObjectCollection _manufacturerInfo = _search.Get();
            string _manufacturerProperty = "";

            foreach (ManagementObject obj in _manufacturerInfo)
            {
                foreach (PropertyData _manufacturer in obj.Properties)
                {
                    _manufacturerProperty = string.Join(" ", "Manufacturer: ", _manufacturer.Value);
                }
            }
            _search.Dispose();

            return _manufacturerProperty;
        }

        /// <summary>
        /// Getting system install date
        /// </summary>
        /// <returns></returns>
        public DateTime GetInstallDate()
        {
            ManagementObjectSearcher _search = new ManagementObjectSearcher("select InstallDate from Win32_BaseBoard");

            ManagementObjectCollection _installdateInfo = _search.Get();
            DateTime _installdateProperty = Convert.ToDateTime("");

            foreach (ManagementObject obj in _installdateInfo)
            {
                foreach (PropertyData _inbstallDate in obj.Properties)
                {
                    _installdateProperty = Convert.ToDateTime(string.Join(" ", "Install date: ", _inbstallDate.Value));
                }
            }
            _search.Dispose();

            return _installdateProperty;
        }

        /// <summary>
        /// Getting status
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
                    _statusproperty = string.Join(" ", "Status: ", _status.Value);
                }
            }
            _search.Dispose();

            return _statusproperty;
        }

        /// <summary>
        /// Getting bios release date
        /// </summary>
        /// <returns></returns>
        public DateTime GetReleaseDate()
        {
            ManagementObjectSearcher _search = new ManagementObjectSearcher("select Release from Win32_BIOS");

            ManagementObjectCollection _releasedateInfo = _search.Get();
            DateTime _releasedateProperty = Convert.ToDateTime("");

            foreach (ManagementObject obj in _releasedateInfo)
            {
                foreach (PropertyData _releasedate in obj.Properties)
                {
                    _releasedateProperty = Convert.ToDateTime(string.Join(" ", "Release date: ", _releasedate.Value));
                }
            }
            _search.Dispose();

            return _releasedateProperty;
        }

        /// <summary>
        /// Getting bios version
        /// </summary>
        /// <returns></returns>
        public string GetBIOSVersion()
        {
            ManagementObjectSearcher _search = new ManagementObjectSearcher("select BIOSVersion from Win32_BIOS");

            ManagementObjectCollection _statusInfo = _search.Get();
            string _statusproperty = "";

            foreach (ManagementObject obj in _statusInfo)
            {
                foreach (PropertyData _status in obj.Properties)
                {
                    _statusproperty = string.Join(" ", "BIOS Version: ", _status.Value);
                }
            }
            _search.Dispose();

            return _statusproperty;
        }
    }
}
