using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace AngularJS.Infrastructure.DotLess
{
    /// <summary>
    /// The less bundle.
    /// </summary>
    public class LessBundle : Bundle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LessBundle"/> class.
        /// </summary>
        /// <param name="virtualPath">
        /// The virtual path.
        /// </param>
        public LessBundle(string virtualPath)
            : base(virtualPath, new IBundleTransform[] { new LessTransform() })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LessBundle"/> class.
        /// </summary>
        /// <param name="virtualPath">
        /// The virtual path.
        /// </param>
        /// <param name="cdnPath">
        /// The CDN path.
        /// </param>
        public LessBundle(string virtualPath, string cdnPath)
            : base(virtualPath, cdnPath, new IBundleTransform[] { new LessTransform() })
        {
        }
    }
}