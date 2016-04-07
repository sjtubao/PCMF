﻿using System;
using System.Linq;
using System.IO;


namespace WorkerRoleController.PrivateWRConfigFileParser
{
    internal class XsdGenerator
    {
        //private const string XsdPlainText = "<?xml version=\"1.0\" encoding=\"utf-8\"?><xsd:schema id=\"root\" xmlns=\"\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:msdata=\"urn:schemas-microsoft-com:xml-msdata\">  <xsd:element name=\"root\">    <xsd:complexType>      <xsd:sequence>        <xsd:element name=\"generalconfig\" maxOccurs=\"1\" minOccurs=\"1\"><xsd:complexType>                              <xsd:attribute name=\"scalingsecondsperloop\" type=\"xsd:integer\" use=\"required\" />                              <xsd:attribute name=\"scalinglogtablename\" type=\"xsd:string\" use=\"required\" />                              <xsd:attribute name=\"logtableentitiespartionkey\" type=\"xsd:string\" use=\"required\" />                              <xsd:attribute name=\"diagnosticsupperthreshold\" type=\"xsd:integer\" use=\"required\" />                              <xsd:attribute name=\"diagnosticslowerthreshold\" type=\"xsd:integer\" use=\"required\" />                              <xsd:attribute name=\"diagnosticsminutestosampleaverages\" type=\"xsd:integer\" use=\"required\" />                              <xsd:attribute name=\"averagevmboottime\" type=\"xsd:integer\" use=\"required\" />                              <xsd:attribute name=\"minutestosleepafterincreasevmnumber\" type=\"xsd:integer\" use=\"required\" />                              <xsd:attribute name=\"minutestosleepafterdecreasevmnumber\" type=\"xsd:integer\" use=\"required\" />                            </xsd:complexType>        </xsd:element>        <xsd:element name=\"subscriptions\" maxOccurs=\"1\" minOccurs=\"1\">          <xsd:complexType>            <xsd:sequence>              <xsd:element name=\"subscription\" maxOccurs=\"unbounded\" minOccurs=\"1\">                <xsd:complexType>                  <xsd:sequence>                    <xsd:element name=\"storages\" maxOccurs=\"1\" minOccurs=\"1\">                      <xsd:complexType>                        <xsd:sequence>                          <xsd:element name=\"storage\" maxOccurs=\"unbounded\" minOccurs=\"1\">                            <xsd:complexType>                              <xsd:attribute name=\"name\" type=\"xsd:string\" use=\"required\" />                              <xsd:attribute name=\"key\" type=\"xsd:string\" use=\"required\" />                            </xsd:complexType>                          </xsd:element>                        </xsd:sequence>                      </xsd:complexType>                    </xsd:element>                    <xsd:element name=\"services\" maxOccurs=\"1\" minOccurs=\"1\">                      <xsd:complexType>                        <xsd:sequence>                          <xsd:element name=\"hostedservice\" maxOccurs=\"unbounded\" minOccurs=\"1\">                            <xsd:complexType>                              <xsd:sequence>                                <xsd:element name=\"schedules\" maxOccurs=\"1\" minOccurs=\"1\">                                  <xsd:complexType>                                    <xsd:sequence>                                      <xsd:element maxOccurs=\"unbounded\" minOccurs=\"1\" name=\"schedule\">                                        <xsd:complexType>                                          <xsd:sequence>                                            <xsd:element minOccurs=\"0\" name=\"description\" type=\"xsd:string\" />                                            <xsd:element minOccurs=\"0\" maxOccurs=\"1\" name=\"daysofweek\">                                              <xsd:complexType>                                                <xsd:sequence>                                                  <xsd:element maxOccurs=\"unbounded\" minOccurs=\"1\" name=\"dayofweek\">                                                    <xsd:complexType>                                                      <xsd:attribute name=\"name\" type=\"xsd:string\" use=\"required\" />                                                    </xsd:complexType>                                                  </xsd:element>                                                </xsd:sequence>                                              </xsd:complexType>                                            </xsd:element>                                            <xsd:element name=\"timelist\" maxOccurs=\"1\" minOccurs=\"1\">                                              <xsd:complexType>                                                <xsd:sequence>                                                  <xsd:element maxOccurs=\"unbounded\" minOccurs=\"1\" name=\"timeschedule\">                                                    <xsd:complexType>                                                      <xsd:attribute name=\"instances\" type=\"xsd:integer\" use=\"required\" />                                                      <xsd:attribute name=\"default\" type=\"xsd:integer\" use=\"optional\" />                                                      <xsd:attribute name=\"hour\" type=\"xsd:integer\" use=\"optional\" />                                                      <xsd:attribute name=\"minute\" type=\"xsd:integer\" use=\"optional\" />                                                    </xsd:complexType>                                                  </xsd:element>                                                </xsd:sequence>                                              </xsd:complexType>                                            </xsd:element>                                          </xsd:sequence>                                          <xsd:attribute name=\"name\" type=\"xsd:string\" use=\"required\" />                                          <xsd:attribute name=\"default\" type=\"xsd:integer\" use=\"optional\" />                                        </xsd:complexType>                                      </xsd:element>                                    </xsd:sequence>                                  </xsd:complexType>                                </xsd:element>                                <xsd:element name=\"deployments\" minOccurs=\"1\" maxOccurs=\"1\">                                  <xsd:complexType>                                    <xsd:sequence>                                      <xsd:element maxOccurs=\"unbounded\" minOccurs=\"1\" name=\"deployment\">                                        <xsd:complexType>                                          <xsd:sequence>                                            <xsd:element name=\"topschedules\" minOccurs=\"0\" maxOccurs=\"1\">                                              <xsd:complexType>                                                <xsd:sequence>                                                  <xsd:element maxOccurs=\"unbounded\" minOccurs=\"1\" name=\"topschedule\">                                                    <xsd:complexType>                                                <xsd:sequence minOccurs=\"0\" maxOccurs=\"1\">                                            <xsd:element minOccurs=\"0\" maxOccurs=\"1\" name=\"daysofweek\">                                              <xsd:complexType>                                                <xsd:sequence>                                                  <xsd:element maxOccurs=\"unbounded\" minOccurs=\"1\" name=\"dayofweek\">                                                    <xsd:complexType>                                                      <xsd:attribute name=\"name\" type=\"xsd:string\" use=\"required\" />                                                    </xsd:complexType>                                                  </xsd:element>                                                </xsd:sequence>                                              </xsd:complexType>                                            </xsd:element>                                                </xsd:sequence>                                                      <xsd:attribute name=\"instances\" type=\"xsd:integer\" use=\"optional\" />                                                      <xsd:attribute name=\"initialhour\" type=\"xsd:integer\" use=\"required\" />                                                      <xsd:attribute name=\"finalhour\" type=\"xsd:integer\" use=\"optional\" />                                                      <xsd:attribute name=\"initialminute\" type=\"xsd:integer\" use=\"optional\" />                                                      <xsd:attribute name=\"finalminute\" type=\"xsd:integer\" use=\"optional\" />                                                      <xsd:attribute name=\"stop\" type=\"xsd:integer\" use=\"optional\" />                                                      <xsd:attribute name=\"delete\" type=\"xsd:integer\" use=\"optional\" />                                                      <xsd:attribute name=\"slot\" type=\"xsd:string\" use=\"optional\" />                                                    </xsd:complexType>                                                  </xsd:element>                                                </xsd:sequence>                                              </xsd:complexType>                                            </xsd:element>                                            <xsd:element name=\"roles\" minOccurs=\"1\" maxOccurs=\"1\">                                              <xsd:complexType>                                                <xsd:sequence>                                                  <xsd:element maxOccurs=\"unbounded\" minOccurs=\"1\" name=\"role\">                                                    <xsd:complexType>                                                      <xsd:sequence>                                                        <xsd:element maxOccurs=\"unbounded\" minOccurs=\"1\" name=\"schedule\">                                                          <xsd:complexType>                                                            <xsd:attribute name=\"name\" type=\"xsd:string\" use=\"required\" />                                                          </xsd:complexType>                                                        </xsd:element>                                                      </xsd:sequence>                                                      <xsd:attribute name=\"name\" type=\"xsd:string\" use=\"required\" />                                                      <xsd:attribute name=\"maxinstances\" type=\"xsd:integer\" use=\"required\" />                                                    </xsd:complexType>                                                  </xsd:element>                                                </xsd:sequence>                                              </xsd:complexType>                                            </xsd:element>                                          </xsd:sequence>                                          <xsd:attribute name=\"name\" type=\"xsd:string\" use=\"required\" />                                          <xsd:attribute name=\"storage\" type=\"xsd:string\" use=\"required\" />                                          <xsd:attribute name=\"storagerelativepath\" type=\"xsd:string\" use=\"required\" />                                        </xsd:complexType>                                      </xsd:element>                                    </xsd:sequence>                                  </xsd:complexType>                                </xsd:element>                              </xsd:sequence>                              <xsd:attribute name=\"name\" type=\"xsd:string\" use=\"required\" />                              <xsd:attribute name=\"urlprefix\" type=\"xsd:string\" use=\"required\" />                            </xsd:complexType>                          </xsd:element>                        </xsd:sequence>                      </xsd:complexType>                    </xsd:element>                  </xsd:sequence>                  <xsd:attribute name=\"name\" type=\"xsd:string\" use=\"required\" />                  <xsd:attribute name=\"id\" type=\"xsd:string\" use=\"required\" />                </xsd:complexType>              </xsd:element>            </xsd:sequence>          </xsd:complexType>        </xsd:element>      </xsd:sequence>    </xsd:complexType>  </xsd:element></xsd:schema>";

        public XsdGenerator()
        {

        }

        public static Stream GetPrivateWorkerRoleControllerConfigXsd()
        {
            if (File.Exists(@"XsdFile\PrivateWorkerRoleControllerConfig.xsd"))
            {
                //byte[] bytes = Encoding.ASCII.GetBytes("");
                Stream memoryStream = new MemoryStream(File.ReadAllBytes(@"XsdFile\PrivateWorkerRoleControllerConfig.xsd"));
                return memoryStream;
            }
            return null;

        }
    }
}
