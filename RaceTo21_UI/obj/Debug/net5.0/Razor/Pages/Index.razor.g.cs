#pragma checksum "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4bcfe9fc69827233df343827a149272c0188cd5"
// <auto-generated/>
#pragma warning disable 1591
namespace RaceTo21_UI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/_Imports.razor"
using RaceTo21_UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/_Imports.razor"
using RaceTo21_UI.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/Pages/Index.razor"
 if (page == Page.Main)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"headTitle\"><div class=\"text\"><h1>Race to 21</h1></div></div>");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row mt-2");
            __builder.AddAttribute(3, "id", "userInput");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-sm-6");
            __builder.AddAttribute(6, "id", "message");
            __builder.AddMarkupContent(7, "\n            Player number: ");
            __builder.OpenElement(8, "strong");
            __builder.AddContent(9, 
#nullable restore
#line 13 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/Pages/Index.razor"
                                    DisplayValue

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n        ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-sm-6");
            __builder.AddAttribute(13, "id", "slideinput");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "type", "range");
            __builder.AddAttribute(16, "min", "2");
            __builder.AddAttribute(17, "max", "10");
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 16 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/Pages/Index.razor"
                                                            UpdateValue

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 19 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/Pages/Index.razor"
     for (int i = 1; i <= playerNumber; i++)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "row mt-2");
            __builder.AddAttribute(21, "id", "players");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "col-sm-6");
            __builder.AddAttribute(24, "id", "playerMessage");
            __builder.AddMarkupContent(25, "\n                Player#");
            __builder.AddContent(26, 
#nullable restore
#line 23 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/Pages/Index.razor"
                        i

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(27, " Name:\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n            ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "col-sm-6");
            __builder.AddAttribute(31, "id", "playerName");
            __builder.OpenElement(32, "input");
            __builder.AddAttribute(33, "type", "text");
            __builder.AddAttribute(34, "placeholder", "Enter Name");
            __builder.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 26 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/Pages/Index.razor"
                                                                       AddPlayers

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 29 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/Pages/Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "BUTTON");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "class", "button");
            __builder.AddAttribute(40, "type", "button");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/Pages/Index.razor"
                                                       () => PageChange(Page.Game)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(42, "\n            START\n        ");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/Pages/Index.razor"
}
else if (page == Page.Game)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(43, "<div class=\"headTitle\"><div class=\"text\"><h1>Race To 21</h1></div></div>");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "pickCard");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "yesOrNo");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "yesOrNoMessage");
            __builder.AddContent(50, 
#nullable restore
#line 47 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/Pages/Index.razor"
                 PlayerShow(currentPlayerIndex)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(51, ", do you want card(s)?\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n            ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "yesOrNoButtons");
            __builder.OpenElement(55, "button");
            __builder.AddAttribute(56, "class", "buttonYes");
            __builder.AddAttribute(57, "type", "button");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/Pages/Index.razor"
                                                                  () => ChoiceChange(true)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(59, "\n                    Yes\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\n                ");
            __builder.OpenElement(61, "button");
            __builder.AddAttribute(62, "class", "buttonNo");
            __builder.AddAttribute(63, "type", "button");
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/Pages/Index.razor"
                                                                 () => ChoiceChange(false)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(65, "\n                    No\n                ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\n\n        ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "buttonChoice");
#nullable restore
#line 60 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/Pages/Index.razor"
             if (buttonChoice)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(69, "<div class=\"pickMessage\">\n                    How many cards do you want?\n                </div>\n                ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "row mt-2");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "col-sm-6 btn-group");
            __builder.AddAttribute(74, "role", "group");
#nullable restore
#line 67 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/Pages/Index.razor"
                         for (int buttonNumber = 1; buttonNumber < 4; buttonNumber++)
                        {
                            int btnNum = buttonNumber;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(75, "button");
            __builder.AddAttribute(76, "type", "button");
            __builder.AddAttribute(77, "class", "btn btn-secondary");
            __builder.AddAttribute(78, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 71 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/Pages/Index.razor"
                                              () => ButtonClick(btnNum)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(79, 
#nullable restore
#line 72 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/Pages/Index.razor"
                                 buttonNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 74 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/Pages/Index.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 77 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/Pages/Index.razor"

            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "tables");
            __builder.OpenElement(82, "table");
            __builder.OpenElement(83, "thead");
            __builder.OpenElement(84, "tr");
#nullable restore
#line 89 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/Pages/Index.razor"
                     for (int i = 0; i < playerNumber; i++)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(85, "th");
            __builder.AddContent(86, 
#nullable restore
#line 91 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/Pages/Index.razor"
                             PlayerShow(i)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 92 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/Pages/Index.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\n            ");
            __builder.OpenElement(88, "tbody");
            __builder.OpenElement(89, "tr");
#nullable restore
#line 97 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/Pages/Index.razor"
                     for (int i = 0; i < playerNumber; i++)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(90, "td");
            __builder.AddContent(91, 
#nullable restore
#line 100 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/Pages/Index.razor"
                             ShowPlayerStatus(i)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(92, "\n                            ");
            __builder.AddContent(93, 
#nullable restore
#line 101 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/Pages/Index.razor"
                             ShowPlayerScore(i)

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 102 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/Pages/Index.razor"
                             if (PlayerCardShow(i) != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/Pages/Index.razor"
                                 foreach (var cardImg in PlayerCardShow(i))
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(94, "li");
            __builder.AddAttribute(95, "class", "list-group-item");
            __builder.OpenElement(96, "img");
            __builder.AddAttribute(97, "src", "card_assets/" + (
#nullable restore
#line 107 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/Pages/Index.razor"
                                                               cardImg

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 109 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/Pages/Index.razor"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/Pages/Index.razor"
                                 
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 113 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/Pages/Index.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 118 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/Pages/Index.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 126 "/Users/cuiwenyue/Projects/RaceTo21_UI/RaceTo21_UI/Pages/Index.razor"
 
    private enum Page
    {
        Main,
        Game
    }

    private Page page = Page.Main;

    private string DisplayValue = "";
    private int playerNumber = 0;
    private int currentPlayerIndex = 0;
    private bool buttonChoice = false;
    private int choiceTime = 0;
    private int cardNumber = 0;

    private void UpdateValue(ChangeEventArgs e)
    {
        DisplayValue = e.Value.ToString();
        playerNumber = int.Parse(DisplayValue);
    }

    private ValueTask PageChange(Page e)
    {
        page = e;
        return ValueTask.CompletedTask;
    }

    static CardTable cardTable = new CardTable();
    Game game = new Game(cardTable);
    public void AddPlayers(ChangeEventArgs e)
    {
        game.AddPlayer((string)e.Value);
        game.CheckPlayer();
    }

    private string PlayerShow(int i)
    {
        return game.PlayerShow(i);
    }

    private ValueTask ChoiceChange(bool b)
    {
        buttonChoice = b;
        choiceTime++;
        if(b == false)
        {
            PlayerStay(currentPlayerIndex);
            NextPlayer();
        }
        return ValueTask.CompletedTask;
    }

    private void PlayerTurn(int playerIndex, bool buttonChoice, int cardNumber)
    {
        Console.WriteLine("Player turn execute");
        game.PlayerTurn(playerIndex, buttonChoice, cardNumber);
    }

    public void ButtonClick(int cardNum)
    {
        cardNumber = cardNum;
        Console.WriteLine("cards number: " + cardNumber);
        PlayerTurn(currentPlayerIndex, buttonChoice, cardNumber);
        NextPlayer();
    }

    private List<string> PlayerCardShow(int i)
    {
        List<Card> cards = game.showPlayerCard(i);
        Console.WriteLine("Here's the cards:");
        Console.Write(cards);
        if (cards != null)
        {
            List<string> showCardInfo = new List<string>();
            foreach (Card card in cards)
            {
                showCardInfo.Add(game.CardsToShow(card));
            }
            return showCardInfo;
        }
        else
        {
            return null;
        }
    }

    private void PlayerStay(int playerIndex)
    {
        game.PlayerStay(playerIndex);
    }

    private string ShowPlayerStatus(int playerIndex)
    {
        return game.showPlayerStatus(playerIndex);
    }

    private string ShowPlayerScore(int playerIndex)
    {
        return game.showPlayerScore(playerIndex);
    }

    private void NextPlayer()
    {
        if (currentPlayerIndex < playerNumber - 1)
        {
            currentPlayerIndex++;
        }
        else
        {
            currentPlayerIndex = 0;
        }
        cardNumber = 0;
        choiceTime = 0;
        buttonChoice = false;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
