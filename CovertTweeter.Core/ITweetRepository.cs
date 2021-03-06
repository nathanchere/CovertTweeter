﻿using System;
using TweetinviCore.Events.EventArguments;
using TweetinviCore.Interfaces.Credentials;

namespace CovertTweeter
{
    public interface ITweetRepository
    {
        event EventHandler<TweetReceivedEventArgs> NewTweet;
        event EventHandler<MessageEventArgs> NewMessage;
        event EventHandler<UserFollowedEventArgs> NewFollower;
        event EventHandler<TweetFavouritedEventArgs> NewFavourite;
        event EventHandler<PulseEventArgs> Heartbeat;
        event EventHandler<StreamExceptionEventArgs> StreamStopped;
        event EventHandler StreamStarted;

        void Start();
        void Pause();
        void Stop();
        ILoggedUser GetCurrentUser();        
    }
}