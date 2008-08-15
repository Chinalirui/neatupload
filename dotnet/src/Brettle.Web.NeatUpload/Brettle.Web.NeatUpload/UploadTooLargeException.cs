/*

NeatUpload - an HttpModule and User Controls for uploading large files
Copyright (C) 2005  Dean Brettle

This library is free software; you can redistribute it and/or
modify it under the terms of the GNU Lesser General Public
License as published by the Free Software Foundation; either
version 2.1 of the License, or (at your option) any later version.

This library is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public
License along with this library; if not, write to the Free Software
Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
*/

using System;
using System.Runtime.Serialization;
using Brettle.Web.NeatUpload.Internal;

namespace Brettle.Web.NeatUpload
{
	[Serializable]
	public class UploadTooLargeException : UploadException
	{			
		public UploadTooLargeException(long maxRequestLength, long requestLength) 
			: base(413, String.Format(ResourceManagerSingleton.GetResourceString("UploadTooLargeMessageFormat"), maxRequestLength, requestLength))
		{
			MaxRequestLength = maxRequestLength;
			RequestLength = requestLength;
		}

		[Obsolete("Use UploadTooLargeException(maxRequestLength, requestLength) instead")]
		public UploadTooLargeException(long maxRequestLength) 
			: this(maxRequestLength, 0)
		{
		}

		protected UploadTooLargeException(SerializationInfo info, StreamingContext context)
			: base (info, context) 
		{
			MaxRequestLength = info.GetInt64("UploadTooLargeException.MaxRequestLength");
			RequestLength = info.GetInt64("UploadTooLargeException.RequestLength");
		}

		public override void GetObjectData (SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData (info, context);
			info.AddValue ("UploadTooLargeException.MaxRequestLength", MaxRequestLength);
			info.AddValue ("UploadTooLargeException.RequestLength", RequestLength);
		}

		public long MaxRequestLength = 0;
		public long RequestLength = 0;
	}
}
