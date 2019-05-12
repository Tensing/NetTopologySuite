﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace NetTopologySuite.Utilities
{
    [Obsolete("Not used anywhere within NTS")]
    public static class PlatformUtilityEx
    {
        [Obsolete("Not used anywhere within NTS")]
        public static ICollection CastPlatform(ICollection self)
        {
            return self;
        }

        [Obsolete("Not used anywhere within NTS")]
        public static ICollection CastPlatform(IList self)
        {
            return self;
        }

        [Obsolete("Not used anywhere within NTS")]
        public static ICollection<T> CastPlatform<T>(IList<T> self)
        {
            return self;
        }
#if HAS_SYSTEM_TEXT_ENCODING_DEFAULT

        [Obsolete("Not used anywhere within NTS")]
        public static Encoding GetDefaultEncoding()
        {
            return Encoding.Default;
        }
#endif

#if HAS_SYSTEM_TEXT_ENCODING_ASCII
        [Obsolete("Not used anywhere within NTS")]
        public static Encoding GetASCIIEncoding()
        {
            return Encoding.ASCII;
        }
#else

        [Obsolete("Not used anywhere within NTS")]
        public static Encoding GetDefaultEncoding()
        {
            return Encoding.UTF8;
        }

#endif
    }
}
