
// Henter inn verdier fra C# (forecasts.daily.time, forecasts.daily.temperature_2m_min, forecasts.daily.temperature_2m_max)
// 
function makePlotly(x, y1, y2) {
    let traces = [
        {
            x: x,
            y: y1,
            name: "Min Temperature",
            line: {
                color: "#387fba",
                width: 3
            }
        }
        , {
            x: x,
            y: y2,
            name: "Max Temperature",
            line: {
                color: "#54ba38",
                width: 3,
            }
        }
    ];


    let layout = {
        title: "Min & Max Temperature Oslo next 7 days",
        yaxis: {
            range: [-20, 30]
        },
       
    };

    //https://plot.ly/javascript/configuration-options/
    let config = {
        responsive: true,
        staticPlot: false
        // editable: true
    };

    Plotly.newPlot("plot", traces, layout, config);
}