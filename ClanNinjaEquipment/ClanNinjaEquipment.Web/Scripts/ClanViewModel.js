﻿ClanViewModel= function (data)
{
    var self = this;
    ko.mapping.fromJS(data, {}, self);

    self.save = function ()
    {
        $.ajax({

            //URL TO CALL controller/action
            url: "/Clans/Save/",
            type: "POST",
            data: ko.toJSON(self),
            contentType: "application/json",
            success: function (data)
            {
                if (data.clanViewModel != null)
                    ko.mapping.fromJS(data.clanViewModel, {}, self);
            },
            error: function (data)
            {
                alert("error!!");
            }

        });
    }

}