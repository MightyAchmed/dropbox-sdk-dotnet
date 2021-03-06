// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The link expiry object</para>
    /// </summary>
    public class LinkExpiry
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<LinkExpiry> Encoder = new LinkExpiryEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<LinkExpiry> Decoder = new LinkExpiryDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="LinkExpiry" /> class.</para>
        /// </summary>
        public LinkExpiry()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is RemoveExpiry</para>
        /// </summary>
        public bool IsRemoveExpiry
        {
            get
            {
                return this is RemoveExpiry;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a RemoveExpiry, or <c>null</c>.</para>
        /// </summary>
        public RemoveExpiry AsRemoveExpiry
        {
            get
            {
                return this as RemoveExpiry;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is SetExpiry</para>
        /// </summary>
        public bool IsSetExpiry
        {
            get
            {
                return this is SetExpiry;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a SetExpiry, or <c>null</c>.</para>
        /// </summary>
        public SetExpiry AsSetExpiry
        {
            get
            {
                return this as SetExpiry;
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
        /// <para>Encoder for  <see cref="LinkExpiry" />.</para>
        /// </summary>
        private class LinkExpiryEncoder : enc.StructEncoder<LinkExpiry>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(LinkExpiry value, enc.IJsonWriter writer)
            {
                if (value is RemoveExpiry)
                {
                    WriteProperty(".tag", "remove_expiry", writer, enc.StringEncoder.Instance);
                    RemoveExpiry.Encoder.EncodeFields((RemoveExpiry)value, writer);
                    return;
                }
                if (value is SetExpiry)
                {
                    WriteProperty(".tag", "set_expiry", writer, enc.StringEncoder.Instance);
                    SetExpiry.Encoder.EncodeFields((SetExpiry)value, writer);
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
        /// <para>Decoder for  <see cref="LinkExpiry" />.</para>
        /// </summary>
        private class LinkExpiryDecoder : enc.UnionDecoder<LinkExpiry>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="LinkExpiry" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override LinkExpiry Create()
            {
                return new LinkExpiry();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override LinkExpiry Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "remove_expiry":
                        return RemoveExpiry.Decoder.DecodeFields(reader);
                    case "set_expiry":
                        return SetExpiry.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>Remove the currently set expiry for the link.</para>
        /// </summary>
        public sealed class RemoveExpiry : LinkExpiry
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<RemoveExpiry> Encoder = new RemoveExpiryEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<RemoveExpiry> Decoder = new RemoveExpiryDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="RemoveExpiry" />
            /// class.</para>
            /// </summary>
            private RemoveExpiry()
            {
            }

            /// <summary>
            /// <para>A singleton instance of RemoveExpiry</para>
            /// </summary>
            public static readonly RemoveExpiry Instance = new RemoveExpiry();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="RemoveExpiry" />.</para>
            /// </summary>
            private class RemoveExpiryEncoder : enc.StructEncoder<RemoveExpiry>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(RemoveExpiry value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="RemoveExpiry" />.</para>
            /// </summary>
            private class RemoveExpiryDecoder : enc.StructDecoder<RemoveExpiry>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="RemoveExpiry" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override RemoveExpiry Create()
                {
                    return new RemoveExpiry();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override RemoveExpiry DecodeFields(enc.IJsonReader reader)
                {
                    return RemoveExpiry.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Set a new expiry or change an existing expiry.</para>
        /// </summary>
        public sealed class SetExpiry : LinkExpiry
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<SetExpiry> Encoder = new SetExpiryEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<SetExpiry> Decoder = new SetExpiryDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="SetExpiry" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public SetExpiry(sys.DateTime value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="SetExpiry" /> class.</para>
            /// </summary>
            private SetExpiry()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public sys.DateTime Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="SetExpiry" />.</para>
            /// </summary>
            private class SetExpiryEncoder : enc.StructEncoder<SetExpiry>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(SetExpiry value, enc.IJsonWriter writer)
                {
                    WriteProperty("set_expiry", value.Value, writer, enc.DateTimeEncoder.Instance);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="SetExpiry" />.</para>
            /// </summary>
            private class SetExpiryDecoder : enc.StructDecoder<SetExpiry>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="SetExpiry" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override SetExpiry Create()
                {
                    return new SetExpiry();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(SetExpiry value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "set_expiry":
                            value.Value = enc.DateTimeDecoder.Instance.Decode(reader);
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
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : LinkExpiry
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
