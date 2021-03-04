﻿<?xml version="1.0" encoding="utf-8"?>

<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
                xmlns:wix="http://schemas.microsoft.com/wix/2006/wi"
                xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl">

  <xsl:output method="xml" indent="yes"/>

  <!--Identity Transform-->
  <xsl:template match="@*|node()">
    <xsl:copy>
      <xsl:apply-templates select ="@*|node() "/>
    </xsl:copy>
  </xsl:template>

  <!--Set up keys for ignoring various file types-->
  <xsl:key name="xml-search" match="wix:Component[contains(wix:File/@Source, '.transform.xml')]" 
           use ="@Id "/>
  
  <!--Match and ignore leftover .xml files -->
  <xsl:template match="wix:Component[key('xml-search', @Id)]"/>
  <xsl:template match="wix:ComponentRef[key('xml-search', @Id)]"/>
 
</xsl:stylesheet>
