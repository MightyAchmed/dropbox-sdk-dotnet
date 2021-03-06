// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The properties error object</para>
    /// </summary>
    public class PropertiesError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<PropertiesError> Encoder = new PropertiesErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<PropertiesError> Decoder = new PropertiesErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="PropertiesError" />
        /// class.</para>
        /// </summary>
        public PropertiesError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Path</para>
        /// </summary>
        public bool IsPath
        {
            get
            {
                return this is Path;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Path, or <c>null</c>.</para>
        /// </summary>
        public Path AsPath
        {
            get
            {
                return this as Path;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is TemplateNotFound</para>
        /// </summary>
        public bool IsTemplateNotFound
        {
            get
            {
                return this is TemplateNotFound;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a TemplateNotFound, or <c>null</c>.</para>
        /// </summary>
        public TemplateNotFound AsTemplateNotFound
        {
            get
            {
                return this as TemplateNotFound;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is RestrictedContent</para>
        /// </summary>
        public bool IsRestrictedContent
        {
            get
            {
                return this is RestrictedContent;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a RestrictedContent, or <c>null</c>.</para>
        /// </summary>
        public RestrictedContent AsRestrictedContent
        {
            get
            {
                return this as RestrictedContent;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="PropertiesError" />.</para>
        /// </summary>
        private class PropertiesErrorEncoder : enc.StructEncoder<PropertiesError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(PropertiesError value, enc.IJsonWriter writer)
            {
                if (value is Path)
                {
                    WriteProperty(".tag", "path", writer, enc.StringEncoder.Instance);
                    Path.Encoder.EncodeFields((Path)value, writer);
                    return;
                }
                if (value is TemplateNotFound)
                {
                    WriteProperty(".tag", "template_not_found", writer, enc.StringEncoder.Instance);
                    TemplateNotFound.Encoder.EncodeFields((TemplateNotFound)value, writer);
                    return;
                }
                if (value is RestrictedContent)
                {
                    WriteProperty(".tag", "restricted_content", writer, enc.StringEncoder.Instance);
                    RestrictedContent.Encoder.EncodeFields((RestrictedContent)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="PropertiesError" />.</para>
        /// </summary>
        private class PropertiesErrorDecoder : enc.UnionDecoder<PropertiesError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="PropertiesError" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override PropertiesError Create()
            {
                return new PropertiesError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override PropertiesError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "path":
                        return Path.Decoder.DecodeFields(reader);
                    case "template_not_found":
                        return TemplateNotFound.Decoder.DecodeFields(reader);
                    case "restricted_content":
                        return RestrictedContent.Decoder.DecodeFields(reader);
                    case "other":
                        return Other.Decoder.DecodeFields(reader);
                    default:
                        throw new sys.InvalidOperationException();
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The path object</para>
        /// </summary>
        public sealed class Path : PropertiesError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Path> Encoder = new PathEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Path> Decoder = new PathDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Path" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public Path(LookupError value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Path" /> class.</para>
            /// </summary>
            private Path()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public LookupError Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Path" />.</para>
            /// </summary>
            private class PathEncoder : enc.StructEncoder<Path>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Path value, enc.IJsonWriter writer)
                {
                    Dropbox.Api.Files.LookupError.Encoder.EncodeFields(value.Value, writer);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Path" />.</para>
            /// </summary>
            private class PathDecoder : enc.StructDecoder<Path>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Path" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Path Create()
                {
                    return new Path();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(Path value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "path":
                            value.Value = Dropbox.Api.Files.LookupError.Decoder.Decode(reader);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Property template does not exist for given identifier.</para>
        /// </summary>
        public sealed class TemplateNotFound : PropertiesError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<TemplateNotFound> Encoder = new TemplateNotFoundEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<TemplateNotFound> Decoder = new TemplateNotFoundDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="TemplateNotFound" />
            /// class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public TemplateNotFound(string value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="TemplateNotFound" />
            /// class.</para>
            /// </summary>
            private TemplateNotFound()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public string Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="TemplateNotFound" />.</para>
            /// </summary>
            private class TemplateNotFoundEncoder : enc.StructEncoder<TemplateNotFound>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(TemplateNotFound value, enc.IJsonWriter writer)
                {
                    WriteProperty("template_not_found", value.Value, writer, enc.StringEncoder.Instance);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="TemplateNotFound" />.</para>
            /// </summary>
            private class TemplateNotFoundDecoder : enc.StructDecoder<TemplateNotFound>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="TemplateNotFound" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override TemplateNotFound Create()
                {
                    return new TemplateNotFound();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(TemplateNotFound value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "template_not_found":
                            value.Value = enc.StringDecoder.Instance.Decode(reader);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>You do not have the permissions to modify this property template.</para>
        /// </summary>
        public sealed class RestrictedContent : PropertiesError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<RestrictedContent> Encoder = new RestrictedContentEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<RestrictedContent> Decoder = new RestrictedContentDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="RestrictedContent" />
            /// class.</para>
            /// </summary>
            private RestrictedContent()
            {
            }

            /// <summary>
            /// <para>A singleton instance of RestrictedContent</para>
            /// </summary>
            public static readonly RestrictedContent Instance = new RestrictedContent();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="RestrictedContent" />.</para>
            /// </summary>
            private class RestrictedContentEncoder : enc.StructEncoder<RestrictedContent>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(RestrictedContent value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="RestrictedContent" />.</para>
            /// </summary>
            private class RestrictedContentDecoder : enc.StructDecoder<RestrictedContent>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="RestrictedContent"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override RestrictedContent Create()
                {
                    return new RestrictedContent();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override RestrictedContent DecodeFields(enc.IJsonReader reader)
                {
                    return RestrictedContent.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : PropertiesError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return new Other();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Other DecodeFields(enc.IJsonReader reader)
                {
                    return Other.Instance;
                }
            }

            #endregion
        }
    }
}
