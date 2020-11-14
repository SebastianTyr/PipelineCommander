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
                    _serialProperty =  string.Join(" ", "Serial number: ", _serialnumber.Value);
                }
            }
            _search.Dispose();

            return _serialProperty;
        }

        /// <summary>
        /// Get device Model
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
                    _nameProperty = string.Join(" ", "Name: ", _name.Value);
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
                    _manufacturerProperty = string.Join(" ", "Manufacturer: ", _manufacturer.Value);
                }
            }
            _search.Dispose();

            return _manufacturerProperty;
        }

        /// <summary>
        /// Get system install date
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
                    _statusproperty = string.Join(" ", "Status: ", _status.Value);
                }
            }
            _search.Dispose();

            return _statusproperty;
        }

        /// <summary>
        /// Get bios release date
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
        /// Get bios version
        /// </summary>
        /// <returns></returns>
        public string GetBIOSVersion()
        {
            ManagementObjectSearcher _search = new ManagementObjectSearcher("select BIOSVersion from Win32_BIOS");

            ManagementObjectCollection _statusInfo = _search.Get();
            string _statusproperty = "";

            foreach (ManagementObject obj in _statusInfo)
            {
                foreach (PropertyData _biosVer in obj.Properties)
                {
                    _statusproperty = string.Join(" ", "BIOS Version: ", _biosVer.Value);
                }
            }
            _search.Dispose();

            return _statusproperty;
        }

        /// <summary>
        /// Get information about current used language
        /// </summary>
        /// <returns></returns>
        public string GetCurrentLang()
        {
            ManagementObjectSearcher _search = new ManagementObjectSearcher("select CurrentLanguage from Win32_BIOS");

            ManagementObjectCollection _currLang = _search.Get();
            string _currLangProperty = "";

            foreach (ManagementObject obj in _currLang)
            {
                foreach (PropertyData _lang in obj.Properties)
                {
                    _currLangProperty = string.Join(" ", "Current Language: ", _lang.Value);
                }
            }
            _search.Dispose();

            return _currLangProperty;
        }

        /// <summary>
        /// Get device description
        /// </summary>
        /// <returns></returns>
        public string GetDescription()
        {
            ManagementObjectSearcher _search = new ManagementObjectSearcher("select CurrentLanguage from Win32_BIOS");

            ManagementObjectCollection _descr = _search.Get();
            string _descrProperty = "";

            foreach (ManagementObject obj in _descr)
            {
                foreach (PropertyData _description in obj.Properties)
                {
                    _descrProperty = string.Join(" ", "Device Description: ", _description.Value);
                }
            }
            _search.Dispose();

            return _descrProperty;
        }

        /// <summary>
        /// Get device identification code
        /// </summary>
        /// <returns></returns>
        public string GetIDCode()
        {
            ManagementObjectSearcher _search = new ManagementObjectSearcher("select CurrentLanguage from Win32_BIOS");

            ManagementObjectCollection _idCode = _search.Get();
            string _idcodeProperty = "";

            foreach (ManagementObject obj in _idCode)
            {
                foreach (PropertyData _code in obj.Properties)
                {
                    _idcodeProperty = string.Join(" ", "Identification Code: ", _code.Value);
                }
            }
            _search.Dispose();

            return _idcodeProperty;
        }

        /// <summary>
        /// Get actual label language
        /// </summary>
        /// <returns></returns>
        public UInt16 GetLabelLang()
        {
            ManagementObjectSearcher _search = new ManagementObjectSearcher("select CurrentLanguage from Win32_BIOS");

            ManagementObjectCollection _labelLang = _search.Get();
            UInt16 _labelLangProperty = 0;

            foreach (ManagementObject obj in _labelLang)
            {
                foreach (PropertyData _labellang in obj.Properties)
                {
                    _labelLangProperty = Convert.ToUInt16(string.Join(" ", "Identification Code: ", _labellang.Value));
                }
            }
            _search.Dispose();

            return _labelLangProperty;
        }

        /// <summary>
        /// Get language edition
        /// </summary>
        /// <returns></returns>
        public string GetLangEdition()
        {
            ManagementObjectSearcher _search = new ManagementObjectSearcher("select LanguageEdition from Win32_BIOS");

            ManagementObjectCollection _langEdition = _search.Get();
            string _langEditionProperty = "";

            foreach (ManagementObject obj in _langEdition)
            {
                foreach (PropertyData _langEdit in obj.Properties)
                {
                    _langEditionProperty = string.Join(" ", "Language Edition: ", _langEdit.Value);
                }
            }
            _search.Dispose();

            return _langEditionProperty;
        }

        /// <summary>
        /// Get language list
        /// </summary>
        /// <returns></returns>
        public string GetCaption()
        {
            ManagementObjectSearcher _search = new ManagementObjectSearcher("select Caption from Win32_BaseBoard");

            ManagementObjectCollection _caption = _search.Get();
            string _captionPoperty = "";

            foreach (ManagementObject obj in _caption)
            {
                foreach (PropertyData _cap in obj.Properties)
                {
                    _captionPoperty = string.Join(" ", "Language Edition: ", _cap.Value);
                }
            }
            _search.Dispose();

            return _captionPoperty;
        }
    }
}
