using DShowNET;

namespace MediaCap.Capture
{
	/// <summary>
	///  Provides collections of devices and compression codecs
	///  installed on the system. 
	/// </summary>
	/// <example>
	///  Devices and compression codecs are implemented in DirectShow 
	///  as filters, see the <see cref="Filter"/> class for more 
	///  information. To list the available video devices:
	///  <code><div style="background-color:whitesmoke;">
	///   Filters filters = new Filters();
	///   foreach ( Filter f in filters.VideoInputDevices )
	///   {
	///		Debug.WriteLine( f.Name );
	///   }
	///  </div></code>
	///  <seealso cref="Filter"/>
	/// </example>
	public class Filters
	{
		// ------------------ Public Properties --------------------

		/// <summary> Collection of available video capture devices. </summary>
		public FilterCollection VideoInputDevices = new FilterCollection( FilterCategory.VideoInputDevice ); 

		/// <summary> Collection of available audio capture devices. </summary>
		public FilterCollection AudioInputDevices = new FilterCollection( FilterCategory.AudioInputDevice ); 

		/// <summary> Collection of available video compressors. </summary>
		public FilterCollection VideoCompressors = new FilterCollection( FilterCategory.VideoCompressorCategory ); 

		/// <summary> Collection of available audio compressors. </summary>
		public FilterCollection AudioCompressors = new FilterCollection( FilterCategory.AudioCompressorCategory ); 
        
		/// <summary> Collection of available audio compressors. </summary>
		public FilterCollection LegacyFilters = new FilterCollection(FilterCategory.LegacyAmFilterCategory); 
	}
}
