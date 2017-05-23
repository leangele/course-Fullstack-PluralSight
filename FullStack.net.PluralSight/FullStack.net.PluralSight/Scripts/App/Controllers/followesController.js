var followesController = function (followeService) {

    var button;

    var fail = function () {
        alert("Something failed");
    }

    var done = function () {
        var text = (button.text() == "Follow") ? "Following":"Follow";
        button.toggleClass(".btn-info").toggleClass(".btn-default").text(text);
    }

    var followGigs = function (e) {
        button = $(e.target);
        var followId = button.attr("data-user-id");

        if (button.hasClass("btn-default")) {
            followeService.createFollowing(followId, done, fail);
        } else {
            followeService.deleteFollowing(followId, done, fail);
        }
        
    }

    var init = function (container) {
        $(container).on("click", ".js-toggle-follow", followGigs);
    }

    return {
        init: init
    }
}(followeService);