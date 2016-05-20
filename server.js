var io = require('socket.io')(process.env.PORT || 3000);

console.log('Server Startet');

var playerCount = 0;

io.on('connection', function(socket)
{
    console.log('client Connected, broadcasting spawn');

    socket.broadcast.emit('spawn');
    playerCount++;

    for (i=0; i < playerCount; i++)
    {
        socket.emit('spawn');
        console.log('sending spawn to new player')
    }

    socket.on('move', function(data)
    {
        console.log('Client moved');
    });

    socket.on('disconnect', function()
    {
        console.log('client disconnected');
        playerCount--;
    });
})