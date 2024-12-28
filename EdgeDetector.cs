using OpenCvSharp;

namespace EdgeDetectionApp
{
	internal static class EdgeDetector
	{
		public const string InputImageName = "input.jpg";
		public const string InputImageFolder = "Images";

		/// <summary>
		/// Applies edge detection with specific thresholds and saves the output image
		/// </summary>
		/// <returns>True if processing was successful, false otherwise</returns>
		public static bool RenderOutputImage(string outputName, double threshold1, double threshold2)
		{
			var inputImagePath = GetImagePath(InputImageName);
			var outputImagePath = GetImagePath(outputName);

			try
			{
				using var sourceImage = Cv2.ImRead(inputImagePath);
				if (sourceImage.Empty())
				{
					Console.WriteLine($"Could not find image at: {inputImagePath}");
					return false;
				}

				using var edgeDetectedImage = new Mat();
				Cv2.Canny(sourceImage, edgeDetectedImage, threshold1, threshold2);
				Cv2.ImWrite(outputImagePath, edgeDetectedImage);
				
				Console.WriteLine($"Edge detection saved to: {outputImagePath}");
				return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error processing image: {ex.Message}");
				return false;
			}
		}

		private static string GetImagePath(string imageName)
			=> Path.Combine(AppDomain.CurrentDomain.BaseDirectory, InputImageFolder, imageName);
	}
}
