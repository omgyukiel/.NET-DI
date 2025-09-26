using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisBookings.Shared.Weather;

namespace TennisBookings.Shared
{
	public class AmazingWeatherForecaster
	{
		public Task<WeatherResult> GetCurrentWeatherAsync(string city)
		{
			return Task.FromResult(new WeatherResult()
			{
				City = city,
				Weather = new WeatherCondition()
				{
					Summary = "Sun"
				}
			});
		}
	}
}
