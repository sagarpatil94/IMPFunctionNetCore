using Microsoft.Playwright;
using System;
using System.Threading.Tasks;

namespace AutoSurvey
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            using (var playwright = await Playwright.CreateAsync())
            {
                await using (var browser = await playwright.Chromium.LaunchAsync(
                    new BrowserTypeLaunchOptions
                    {
                        Headless = false,
                        SlowMo = 50
                    }))
                {
                    var page = await browser.NewPageAsync();
                    await page.GotoAsync("https://forms.office.com/r/gT6mmmqctE");
                    await page.ClickAsync("text=Check in");
                    await page.WaitForTimeoutAsync(1000);
                    await page.ClickAsync("text=Yes");
                    await page.WaitForTimeoutAsync(1000);
                    await page.ClickAsync("text=Center buidding");
                    await page.WaitForTimeoutAsync(1000);
                    await page.ClickAsync("text=QMS");
                    await page.WaitForTimeoutAsync(1000);
                    await page.TypeAsync("input[class=\"office-form-question-textbox office-form-textfield-input form-control office-form-theme-focus-border border-no-radius\"]", "Type here");
                    await page.WaitForTimeoutAsync(1000);
                    await page.ClickAsync("button[title=\"Submit\"]");
                    await page.WaitForTimeoutAsync(10000);
                }
            }
        }
    }
}
