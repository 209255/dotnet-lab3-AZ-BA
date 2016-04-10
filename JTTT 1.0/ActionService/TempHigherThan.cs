using System;

namespace JTTT_1._0
{
    class TempHigherThan : IAction
    {
        public string ActionName { get; set; } = "Check if temperature is higher than";

        public override string[] DoAction(IModel model)
        {
            var myModel = model as MTempHigherThan;
            Services.Instance.Logger.AddAction(ActionName + "\t" + myModel.City + "\t" + myModel.TempTrigger);

            try {
                var weather = Services.Instance.WeatherService.GetCurrentWeather(myModel.City);

                string description = new WeatherInfoForm().Parse(weather);

                if ((weather.main.temp-273) < myModel.TempTrigger)
                    return null;

                string imgUrl = Services.Instance.WeatherService.GetWeatherImgURL(weather);
                return new string[] { imgUrl, description };
            }
            catch
            {
                Console.WriteLine("@@@@ nich weather @@@@@");
                throw;
            }
        }

        public override string GetActionName()
        {
            return ActionName;
        }

        public override IModel GetEmptyModel()
        {
            return new MTempHigherThan();
        }

        public TempHigherThan()
        {
            Services.Instance.ActionRegister.RegisterAction(this);
        }
    }
}
