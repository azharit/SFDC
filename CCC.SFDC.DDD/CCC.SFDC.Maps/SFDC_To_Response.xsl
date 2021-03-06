<?xml version="1.0" encoding="UTF-16"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" xmlns:var="http://schemas.microsoft.com/BizTalk/2003/var" exclude-result-prefixes="msxsl var" version="1.0" xmlns:ns0="http://CCC.SFDC.DDD.SFDC">
  <xsl:output omit-xml-declaration="yes" method="xml" version="1.0" />
  <xsl:template match="/">
    <xsl:apply-templates select="/ns0:Request" />
  </xsl:template>
  <xsl:template match="/ns0:Request">
    
      <xsl:variable name="Accounts">
        <xsl:for-each select="sObjects/sObject">
          <xsl:variable name="account">
            <xsl:value-of select="Account"/>
          </xsl:variable>
            <xsl:value-of select="concat($account,',')"/>
        </xsl:for-each>
      </xsl:variable>
    
    <xsl:variable name="NewAccs">
        <xsl:value-of select="substring($Accounts, 1, string-length($Accounts) - 1)"/>
      </xsl:variable>

    <ns0:Response>
      <Result>
         <xsl:value-of select="concat('Following POs are successfully processed: ',$NewAccs)"/>
      </Result>
    </ns0:Response>
  </xsl:template>
</xsl:stylesheet>