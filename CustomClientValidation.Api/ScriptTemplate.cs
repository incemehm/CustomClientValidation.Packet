﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace CustomClientValidation.Api
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\mehmeti\source\repos\ProxyApi-master\CustomClientValidation.Api\ScriptTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class ScriptTemplate : ScriptTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("\r\n(function($) {\n\t\"use strict\";\n\n\tif (!$) {\n\t\tthrow \"jQuery is required\";\n\t}\n\t \n\t" +
                    "var validDateFormats = [\"DD/MM/YYYY\", \"MM/DD/YYYY\", \"DD-MM-YYYY\", \"MM-DD-YYYY\", " +
                    "\"DD.MM.YYYY\", \"MM.DD.YYYY\"];\r\n\t$.validator.methods.date = function (value, eleme" +
                    "nt) {\r\n\t\treturn this.optional(element) || moment(value, validDateFormats, true)." +
                    "isValid();\r\n\t}\r\n\r\n\t$.validator.addMethod(\"dategreaterthan\", function (value, ele" +
                    "ment, params) {\r\n\t\treturn moment(value, validDateFormats, true).isAfter(moment($" +
                    "(params).val(), validDateFormats, true));\r\n\t});\r\n\r\n\t$.validator.addMethod(\"equal" +
                    "stoproperty\", function (value, element, params) {\r\n\t\treturn value === $(params)." +
                    "val();\r\n\t});\r\n\r\n\t$.validator.addMethod(\"excludechars\", function (value, element," +
                    " params) {\r\n\t\tif (value) \r\n\t\t\tfor (var i = 0; i < params.length; i++) \r\n\t\t\t\tif (" +
                    "$.inArray(params[i], value) != -1) \r\n\t\t\t\t\treturn false;         \r\n\t\treturn true;" +
                    "\r\n\t});\r\n\r\n\t$.validator.addMethod(\"mustbechecked\", function (value, element, para" +
                    "ms) {\r\n\t\treturn $(element).is(\":checked\");\r\n\t});\r\n\r\n\t$.validator.addMethod(\"vali" +
                    "dateage\", function (value, element, params) {\r\n\r\n\t\treturn moment(value, validDat" +
                    "eFormats, true)\r\n\t\t\t.isBetween(\r\n\t\t\tmoment(params.minimumdate, validDateFormats)" +
                    ",\r\n\t\t\tmoment(params.maximumdate, validDateFormats),\r\n\t\t\t\tnull, \'[]\');\r\n\t});\r\n\r\n\t" +
                    "$.validator.addMethod(\"requiredif\", function (value, element, params) {\r\n\t\tif ($" +
                    "(element).val() != \'\') return true\r\n\t\tvar $toproperty = $(\'#\' + params.topropert" +
                    "y);\r\n\t\tvar toPropertyValue = ($toproperty.prop(\'type\').toUpperCase() == \"CHECKBO" +
                    "X\") ?\r\n\t\t\t\t\t\t\t  ($toproperty.prop(\"checked\") ? \"true\" : \"false\") :\r\n\t\t\t\t\t\t\t  ($t" +
                    "oproperty.val().trim() || \"\");\r\n\r\n\t\tswitch (params.comparison) {\r\n\t\t\tcase \'isequ" +
                    "alto\':\r\n\t\t\t\treturn !((toPropertyValue !== \"\" && toPropertyValue === params.compa" +
                    "risonvalue) && $.trim(value).length === 0);\r\n\t\t\tcase \'isnotequalto\':\r\n\t\t\t\treturn" +
                    " !((toPropertyValue === \"\" || toPropertyValue !== params.comparisonvalue) && $.t" +
                    "rim(value).length === 0);\r\n\t\t\tcase \'isempty\':\r\n\t\t\t\treturn !(toPropertyValue === " +
                    "\"\" && $.trim(value).length === 0);\r\n\t\t\tcase \'isnotempty\':\r\n\t\t\t\treturn !(toProper" +
                    "tyValue !== \"\" && $.trim(value).length === 0);\r\n\t\t\tdefault:\r\n\t\t\t\treturn !((toPro" +
                    "pertyValue !== \"\" && toPropertyValue === params.comparisonvalue) && $.trim(value" +
                    ").length === 0);\r\n\t\t}\r\n\t});\r\n\r\n\t$.validator.unobtrusive.adapters.add(\"dategreate" +
                    "rthan\", [\"toproperty\"], function (options) {\r\n\t\toptions.rules[\"dategreaterthan\"]" +
                    " = \"#\" + options.params.toproperty;\r\n\t\toptions.messages[\"dategreaterthan\"] = opt" +
                    "ions.message;\r\n\t});\r\n\r\n\t$.validator.unobtrusive.adapters.add(\"equalstoproperty\"," +
                    " [\"toproperty\"], function (options) {\r\n\t\toptions.rules[\"equalstoproperty\"] = \"#\"" +
                    " + options.params.toproperty;\r\n\t\toptions.messages[\"equalstoproperty\"] = options." +
                    "message;\r\n\t});\r\n\r\n\t$.validator.unobtrusive.adapters.addSingleVal(\"excludechars\"," +
                    " \"chars\");\r\n\r\n\t$.validator.unobtrusive.adapters.addBool(\"mustbechecked\");\r\n\r\n\t$." +
                    "validator.unobtrusive.adapters.add(\"validateage\", [\"minimumdate\", \"maximumdate\"]" +
                    ", function (options) {\r\n\t\tvar params = {\r\n\t\t\tminimumdate: options.params.minimum" +
                    "date,\r\n\t\t\tmaximumdate: options.params.maximumdate\r\n\t\t};\r\n\t\toptions.rules[\"valida" +
                    "teage\"] = params;\r\n\t\toptions.messages[\"validateage\"] = options.message;\r\n\t});\r\n\r" +
                    "\n\t$.validator.unobtrusive.adapters.add(\"requiredif\", [\"toproperty\", \"comparison\"" +
                    ", \"comparisonvalue\"], function (options) {\r\n\t\toptions.rules[\'requiredif\'] = {\r\n\t" +
                    "\t\ttoproperty: options.params.toproperty,\r\n\t\t\tcomparison: options.params.comparis" +
                    "on,\r\n\t\t\tcomparisonvalue: options.params.comparisonvalue\r\n\t\t};\r\n\t\toptions.message" +
                    "s[\'requiredif\'] = options.message;\r\n\t});\r\n\n}(jQuery));");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public class ScriptTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
