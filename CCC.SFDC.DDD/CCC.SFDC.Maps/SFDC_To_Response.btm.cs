namespace CCC.SFDC.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CCC.SFDC.DDD.SFDC+Request", typeof(global::CCC.SFDC.DDD.SFDC.Request))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CCC.SFDC.DDD.SFDC+Response", typeof(global::CCC.SFDC.DDD.SFDC.Response))]
    public sealed class SFDC_To_Response : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var"" version=""1.0"" xmlns:ns0=""http://CCC.SFDC.DDD.SFDC"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:Request"" />
  </xsl:template>
  <xsl:template match=""/ns0:Request"">
    
      <xsl:variable name=""Accounts"">
        <xsl:for-each select=""sObjects/sObject"">
          <xsl:variable name=""account"">
            <xsl:value-of select=""Account""/>
          </xsl:variable>
            <xsl:value-of select=""concat($account,',')""/>
        </xsl:for-each>
      </xsl:variable>
    
    <xsl:variable name=""NewAccs"">
        <xsl:value-of select=""substring($Accounts, 1, string-length($Accounts) - 1)""/>
      </xsl:variable>

    <ns0:Response>
      <Result>
         <xsl:value-of select=""concat('Following POs are successfully processed: ',$NewAccs)""/>
      </Result>
    </ns0:Response>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"CCC.SFDC.DDD.SFDC+Request";
        
        private const global::CCC.SFDC.DDD.SFDC.Request _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"CCC.SFDC.DDD.SFDC+Response";
        
        private const global::CCC.SFDC.DDD.SFDC.Response _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"CCC.SFDC.DDD.SFDC+Request";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"CCC.SFDC.DDD.SFDC+Response";
                return _TrgSchemas;
            }
        }
    }
}
