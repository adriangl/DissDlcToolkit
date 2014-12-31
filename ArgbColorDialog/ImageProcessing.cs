
using System;
using System.Drawing;

namespace CutoutPro.Winforms
{
	/// <summary>
	/// Description of ImageProcessing.
	/// </summary>
	public class ImageProcessing
	{
		public static void Invert(RectangleF rect, Bitmap image)
		{
			int w = image.Width;
			int h = image.Height;
			int rectX = (int)rect.X;
			int rectY = (int)rect.Y;
			int rectMaxX = (int)(rect.X + rect.Width);
			int rectMaxY = (int)(rect.Y + rect.Height);
			System.Drawing.Imaging.BitmapData data = image.LockBits(new Rectangle(0, 0, w, h), 
				System.Drawing.Imaging.ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
			unsafe
			{
				byte* start = (byte*)data.Scan0.ToPointer();
				int stride = data.Stride;
				byte* cur;
				for (int x = rectX; x < rectMaxX; x++)
				{
					for (int y = rectY; y < rectMaxY; y++)
					{
						if (x >= 0 && x < w && y >= 0 && y < h)
						{
							cur = start + x * 4 + y * stride;
							*cur = (byte)(255 - *cur);
							cur++;
							*cur = (byte)(255 - *cur);
							cur++;
							*cur = (byte)(255 - *cur);
							cur++;
						}
					}
				}
			}

			image.UnlockBits(data);
		}
		
		public static void Hsv(Rectangle rect, Bitmap image)
		{
			int w = image.Width;
			int h = image.Height;
			int rectX = (int)rect.X;
			int rectY = (int)rect.Y;
			float invRectWidth = 1f/rect.Width;
			float halfInvRectHeight = 0.5f/rect.Height;
			int rectMaxX = (int)(rect.X + rect.Width);
			int rectMaxY = (int)(rect.Y + rect.Height);
			float fx, hue, saturation;
			byte v, p, q, t;
			int hi;
			float inv60 = 1f/60;
			float f;
			int x, y;
			
			// Boundary check.
			rectX = rectX < 0 ? 0 : rectX;
			rectY = rectY < 0 ? 0 : rectY;
			rectMaxX = rectMaxX >= w ? w : rectMaxX;
			rectMaxY = rectMaxY >= h ? h : rectMaxY;
			
			System.Drawing.Imaging.BitmapData data = image.LockBits(new Rectangle(0, 0, w, h), 
				System.Drawing.Imaging.ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
			unsafe
			{
				byte* start = (byte*)data.Scan0.ToPointer();
				int stride = data.Stride;
				byte* cur;
				
				for (x = rectX; x < rectMaxX; x++)
				{
					for (y = rectY; y < rectMaxY; y++)
					{
						fx = (x-rectX) * invRectWidth;
						hue = fx*360;
						
						// Calculate directly to save operations.
						// fy = (y-rectY) * invRectHeight;
						// saturation = fy*0.5f;
						saturation = (y-rectY) * halfInvRectHeight;
						
						hi = (int)(hue * inv60);
						f = hue * inv60 - hi;
						hi = hi % 6;
					
					    v = 255;
					    p = (byte)(255 * (1 - saturation));
					    q = (byte)(255 * (1 - f * saturation));
					    t = (byte)(255 * (1 - (1 - f) * saturation));
					
					    // red = hi == 0 ? v : hi == 1 ? q : hi == 2 ? p : hi == 3 ? p : hi == 4 ? t : v;
					    // green = hi == 0 ? t : hi == 1 ? v : hi == 2 ? v : hi == 3 ? q : hi == 4 ? p : p;
					    // blue = hi == 0 ? p : hi == 1 ? p : hi == 2 ? t : hi == 3 ? v : hi == 4 ? v : q;
						
						cur = start + x * 4 + y * stride;
						*cur = hi == 0 || hi == 1 ? p : hi == 2 ? t : hi == 3 || hi == 4 ? v : q;
						cur++;
						*cur = hi == 0 ? t : hi == 1 || hi == 2 ? v : hi == 3 ? q : p;
						cur++;
						*cur = hi == 1 ? q : hi == 2 || hi == 3 ? p : hi == 4 ? t : v;
						cur++;
						*cur = 255; // full opacity.
					}
				}
			}

			image.UnlockBits(data);
		}
	}
}
