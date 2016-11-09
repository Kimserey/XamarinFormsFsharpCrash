namespace FSharpCrash.Core

open System
open System.Threading
open System.Threading.Tasks
open Xamarin.Forms

type MyPage() as self =
    inherit ContentPage()

    let button = Button(Text = "Click Me!",
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        HorizontalOptions = LayoutOptions.CenterAndExpand)
    do
        self.Title <- "My content page"
        self.Content <- button

type MainPage() as self =
    inherit NavigationPage()

    do 
        self.PushAsync(new MyPage())
        |> Async.AwaitTask
        |> Async.StartImmediate


type App() as self =
    inherit Application()

    do
        self.MainPage <- new MainPage()
