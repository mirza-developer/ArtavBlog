$(document).ready(function () {
    $('.hide-chat-box').click(function () {
        $('.chat-content').slideToggle();
    });
    $('.chat-content').slideToggle(); // make default mode of dialog is close
    var userChatTag = $('<img>')
        .attr('src', '/setting/GetImageByUrl?imageUrl=~/images/app/user.png');
    var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();
    connection.start().catch(function (e) {
    });
    connection.on("GuestReceive", (message) => {
        var messageText = message;
        var li = $('<li>').addClass('pl-2')
            .addClass('rounded')
            .addClass('mb-1')
            .addClass('send-msg')
            .addClass('text-center')
            .addClass('text-white')
            .addClass('bg-primary')
            .addClass('pr-2');
        li.html(messageText);
        $('#support-chatlist').append(li);
    });

    $('#btn-send').click(function () {
        var message = $('#txt-message').val();
        if (message === '') {
            return;
        }
        $('#txt-message').val('');
        connection.invoke('GuestSend', message).catch(err => console.error(err.toString()));
        var li = $('<li>').addClass('p-1').addClass('rounded').addClass('mb-1');//document.createElement("li").classList.add('  ');
        var divParent = $('<div>').addClass('receive-msg');
        li.append(divParent);
        var image = userChatTag;
        divParent.append(image);
        var divChild = $('<div>')
            .addClass('receive-msg-desc')
            .addClass('text-left')
            .addClass('mt-1')
            .addClass('pl-2')
            .addClass('pr-2');
        var pMain = $('<div>').addClass('pl-2').addClass('pr-2').addClass('rounded').html(message);
        divChild.append(pMain);
        divParent.append(divChild);
        li.append(divParent);
        $('#support-chatlist').append(li);
        event.preventDefault();
    });



});