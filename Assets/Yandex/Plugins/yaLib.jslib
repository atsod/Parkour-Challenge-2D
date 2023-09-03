mergeInto(LibraryManager.library, {

    Hello: function () {
        window.alert("Hello, world!");
        console.log("Hellow, world!!!");
    },

    ShowFullscreenAdv: function () {
        ysdk.adv.showFullscreenAdv({
            callbacks: {
                onOpen: function () {
                    myGameInstance.SendMessage("Yandex", "OnOpenAdv");
                },
                onClose: function (wasShown) {
                    myGameInstance.SendMessage("Yandex", "OnCloseAdv");
                },
                onError: function (error) {
                    // some action on error
                }
            }
        })
    },
});