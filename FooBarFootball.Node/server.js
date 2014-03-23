console.log('FooBar Football server starting...');
var queue_playertopitch = require('./listener_queue_playertopitch');
var queue_playerattackplayer = require('./listener_queue_playerattackplayer');
var queue_endturn = require('./listener_queue_endturn');
var game_listener = require('./listener_game');
queue_playertopitch.listen();
queue_playerattackplayer.listen();
queue_endturn.listen();
game_listener.listen();