﻿using System.Collections.Generic;

namespace dot10.PE {
	/// <summary>
	/// Interface to access a PE image
	/// </summary>
	interface IPEImage {
		/// <summary>
		/// Returns the DOS header
		/// </summary>
		ImageDosHeader ImageDosHeader { get; }

		/// <summary>
		/// Returns the NT headers
		/// </summary>
		ImageNTHeaders ImageNTHeaders { get; }

		/// <summary>
		/// Returns the section headers
		/// </summary>
		IList<ImageSectionHeader> ImageSectionHeaders { get; }

		/// <summary>
		/// Converts a <see cref="FileOffset"/> to an <see cref="RVA"/>
		/// </summary>
		/// <param name="offset">The file offset to convert</param>
		/// <returns>The RVA</returns>
		RVA ToRVA(FileOffset offset);

		/// <summary>
		/// Converts an <see cref="RVA"/> to a <see cref="FileOffset"/>
		/// </summary>
		/// <param name="rva">The RVA to convert</param>
		/// <returns>The file offset</returns>
		FileOffset ToFileOffset(RVA rva);
	}
}