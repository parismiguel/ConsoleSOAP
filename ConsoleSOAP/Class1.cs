/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */
using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Xml2CSharp
{
    [XmlRoot(ElementName = "BuildingId", Namespace = "http://tempuri.org/")]
    public class BuildingId
    {
        [XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string Nil { get; set; }
    }

    [XmlRoot(ElementName = "CaseType", Namespace = "http://tempuri.org/")]
    public class CaseType
    {
        [XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string Nil { get; set; }
    }

    [XmlRoot(ElementName = "ChargeId", Namespace = "http://tempuri.org/")]
    public class ChargeId
    {
        [XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string Nil { get; set; }
    }

    [XmlRoot(ElementName = "CityId", Namespace = "http://tempuri.org/")]
    public class CityId
    {
        [XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string Nil { get; set; }
    }

    [XmlRoot(ElementName = "CodeDepto", Namespace = "http://tempuri.org/")]
    public class CodeDepto
    {
        [XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string Nil { get; set; }
    }

    [XmlRoot(ElementName = "CodeInmediateBoss", Namespace = "http://tempuri.org/")]
    public class CodeInmediateBoss
    {
        [XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string Nil { get; set; }
    }

    [XmlRoot(ElementName = "CodeProfile", Namespace = "http://tempuri.org/")]
    public class CodeProfile
    {
        [XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string Nil { get; set; }
    }

    [XmlRoot(ElementName = "CompanyId", Namespace = "http://tempuri.org/")]
    public class CompanyId
    {
        [XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string Nil { get; set; }
    }

    [XmlRoot(ElementName = "CountryId", Namespace = "http://tempuri.org/")]
    public class CountryId
    {
        [XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string Nil { get; set; }
    }

    [XmlRoot(ElementName = "ExpirationDate", Namespace = "http://tempuri.org/")]
    public class ExpirationDate
    {
        [XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string Nil { get; set; }
    }

    [XmlRoot(ElementName = "FloorId", Namespace = "http://tempuri.org/")]
    public class FloorId
    {
        [XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string Nil { get; set; }
    }

    [XmlRoot(ElementName = "Level", Namespace = "http://tempuri.org/")]
    public class Level
    {
        [XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string Nil { get; set; }
    }

    [XmlRoot(ElementName = "KnowledgeLevel", Namespace = "http://tempuri.org/")]
    public class KnowledgeLevel
    {
        [XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string Nil { get; set; }
    }

    [XmlRoot(ElementName = "NumberDepartmentId", Namespace = "http://tempuri.org/")]
    public class NumberDepartmentId
    {
        [XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string Nil { get; set; }
    }

    [XmlRoot(ElementName = "ProfileId", Namespace = "http://tempuri.org/")]
    public class ProfileId
    {
        [XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string Nil { get; set; }
    }

    [XmlRoot(ElementName = "SiteId", Namespace = "http://tempuri.org/")]
    public class SiteId
    {
        [XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string Nil { get; set; }
    }

    [XmlRoot(ElementName = "Ula", Namespace = "http://tempuri.org/")]
    public class Ula
    {
        [XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string Nil { get; set; }
    }

    [XmlRoot(ElementName = "UserActive", Namespace = "http://tempuri.org/")]
    public class UserActive
    {
        [XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string Nil { get; set; }
    }

    [XmlRoot(ElementName = "UserBirthDate", Namespace = "http://tempuri.org/")]
    public class UserBirthDate
    {
        [XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string Nil { get; set; }
    }

    [XmlRoot(ElementName = "UserType", Namespace = "http://tempuri.org/")]
    public class UserType
    {
        [XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string Nil { get; set; }
    }

    [XmlRoot(ElementName = "UssId", Namespace = "http://tempuri.org/")]
    public class UssId
    {
        [XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string Nil { get; set; }
    }

    [XmlRoot(ElementName = "ProjectId", Namespace = "http://tempuri.org/")]
    public class ProjectId
    {
        [XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string Nil { get; set; }
    }

    [XmlRoot(ElementName = "User", Namespace = "http://tempuri.org/")]
    public class User
    {
        [XmlElement(ElementName = "BuildingId", Namespace = "http://tempuri.org/")]
        public BuildingId BuildingId { get; set; }
        [XmlElement(ElementName = "CaseType", Namespace = "http://tempuri.org/")]
        public CaseType CaseType { get; set; }
        [XmlElement(ElementName = "ChargeId", Namespace = "http://tempuri.org/")]
        public ChargeId ChargeId { get; set; }
        [XmlElement(ElementName = "CityId", Namespace = "http://tempuri.org/")]
        public CityId CityId { get; set; }
        [XmlElement(ElementName = "CodeDepto", Namespace = "http://tempuri.org/")]
        public CodeDepto CodeDepto { get; set; }
        [XmlElement(ElementName = "CodeInmediateBoss", Namespace = "http://tempuri.org/")]
        public CodeInmediateBoss CodeInmediateBoss { get; set; }
        [XmlElement(ElementName = "CodeProfile", Namespace = "http://tempuri.org/")]
        public CodeProfile CodeProfile { get; set; }
        [XmlElement(ElementName = "CodeUser", Namespace = "http://tempuri.org/")]
        public string CodeUser { get; set; }
        [XmlElement(ElementName = "CompanyId", Namespace = "http://tempuri.org/")]
        public CompanyId CompanyId { get; set; }
        [XmlElement(ElementName = "CountryId", Namespace = "http://tempuri.org/")]
        public CountryId CountryId { get; set; }
        [XmlElement(ElementName = "ExpirationDate", Namespace = "http://tempuri.org/")]
        public ExpirationDate ExpirationDate { get; set; }
        [XmlElement(ElementName = "FloorId", Namespace = "http://tempuri.org/")]
        public FloorId FloorId { get; set; }
        [XmlElement(ElementName = "Level", Namespace = "http://tempuri.org/")]
        public Level Level { get; set; }
        [XmlElement(ElementName = "KnowledgeLevel", Namespace = "http://tempuri.org/")]
        public KnowledgeLevel KnowledgeLevel { get; set; }
        [XmlElement(ElementName = "NumberDepartmentId", Namespace = "http://tempuri.org/")]
        public NumberDepartmentId NumberDepartmentId { get; set; }
        [XmlElement(ElementName = "ProfileId", Namespace = "http://tempuri.org/")]
        public ProfileId ProfileId { get; set; }
        [XmlElement(ElementName = "SiteId", Namespace = "http://tempuri.org/")]
        public SiteId SiteId { get; set; }
        [XmlElement(ElementName = "Ula", Namespace = "http://tempuri.org/")]
        public Ula Ula { get; set; }
        [XmlElement(ElementName = "Uname", Namespace = "http://tempuri.org/")]
        public string Uname { get; set; }
        [XmlElement(ElementName = "UserActive", Namespace = "http://tempuri.org/")]
        public UserActive UserActive { get; set; }
        [XmlElement(ElementName = "UserBirthDate", Namespace = "http://tempuri.org/")]
        public UserBirthDate UserBirthDate { get; set; }
        [XmlElement(ElementName = "UserType", Namespace = "http://tempuri.org/")]
        public UserType UserType { get; set; }
        [XmlElement(ElementName = "UssId", Namespace = "http://tempuri.org/")]
        public UssId UssId { get; set; }
        [XmlElement(ElementName = "ProjectId", Namespace = "http://tempuri.org/")]
        public ProjectId ProjectId { get; set; }
        [XmlElement(ElementName = "Role", Namespace = "http://tempuri.org/")]
        public string Role { get; set; }
    }

    [XmlRoot(ElementName = "ListPerfilesResult", Namespace = "http://tempuri.org/")]
    public class ListPerfilesResult
    {
        [XmlElement(ElementName = "User", Namespace = "http://tempuri.org/")]
        public List<User> User { get; set; }
    }

    [XmlRoot(ElementName = "ListPerfilesResponse", Namespace = "http://tempuri.org/")]
    public class ListPerfilesResponse
    {
        [XmlElement(ElementName = "ListPerfilesResult", Namespace = "http://tempuri.org/")]
        public ListPerfilesResult ListPerfilesResult { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }

    [XmlRoot(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class Body
    {
        [XmlElement(ElementName = "ListPerfilesResponse", Namespace = "http://tempuri.org/")]
        public ListPerfilesResponse ListPerfilesResponse { get; set; }
    }

    [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class Envelope
    {
        [XmlElement(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public Body Body { get; set; }
        [XmlAttribute(AttributeName = "soap", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Soap { get; set; }
        [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsi { get; set; }
        [XmlAttribute(AttributeName = "xsd", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsd { get; set; }
    }

}
