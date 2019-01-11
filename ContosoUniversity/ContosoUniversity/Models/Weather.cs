using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Weather
    {       
	//"reason":"successed!",
	//"result":{
	//	"sk":{
	//		"temp":"11",
	//		"wind_direction":"南风",
	//		"wind_strength":"1级",
	//		"humidity":"99%",
	//		"time":"08:33"
	//	},
	//	"today":{
	//		"temperature":"12℃~17℃",
	//		"weather":"小雨",
	//		"weather_id":{
	//			"fa":"07",
	//			"fb":"07"
	//		},
	//		"wind":"西南风微风",
	//		"week":"星期五",
	//		"city":"玉林",
	//		"date_y":"2019年01月11日",
	//		"dressing_index":"较冷",
	//		"dressing_advice":"建议着厚外套加毛衣等服装。年老体弱者宜着大衣、呢外套加羊毛衫。",
	//		"uv_index":"最弱",
	//		"comfort_index":"",
	//		"wash_index":"不宜",
	//		"travel_index":"较不宜",
	//		"exercise_index":"较不宜",
	//		"drying_index":""
	//	},
        [DisplayName("温度")]
        // result/today/"temperature":"12℃~17℃",
        public string Temperature { get; set; }
        [DisplayName("城市")]
        //result/today/"city":"玉林",
        public string City { get; set; }
        [DisplayName("天气")]
        public string WeatherInfo { get;set;}
        [DisplayName("穿衣指数")]
        //		"dressing_advice":"建议着厚外套加毛衣等服装。年老体弱者宜着大衣、呢外套加羊毛衫。",
        public string Wind_strength { get; set; }
        [DisplayName("湿度")]
        //result/
        public string Humidity { get; set; }

        public string  Wind { get; set; }
       
    }
}