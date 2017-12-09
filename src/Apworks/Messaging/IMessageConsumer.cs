﻿// ==================================================================================================================                                                                                          
//        ,::i                                                           BBB                
//       BBBBBi                                                         EBBB                
//      MBBNBBU                                                         BBB,                
//     BBB. BBB     BBB,BBBBM   BBB   UBBB   MBB,  LBBBBBO,   :BBG,BBB :BBB  .BBBU  kBBBBBF 
//    BBB,  BBB    7BBBBS2BBBO  BBB  iBBBB  YBBJ :BBBMYNBBB:  FBBBBBB: OBB: 5BBB,  BBBi ,M, 
//   MBBY   BBB.   8BBB   :BBB  BBB .BBUBB  BB1  BBBi   kBBB  BBBM     BBBjBBBr    BBB1     
//  BBBBBBBBBBBu   BBB    FBBP  MBM BB. BB BBM  7BBB    MBBY .BBB     7BBGkBB1      JBBBBi  
// PBBBFE0GkBBBB  7BBX   uBBB   MBBMBu .BBOBB   rBBB   kBBB  ZBBq     BBB: BBBJ   .   iBBB  
//BBBB      iBBB  BBBBBBBBBE    EBBBB  ,BBBB     MBBBBBBBM   BBB,    iBBB  .BBB2 :BBBBBBB7  
//vr7        777  BBBu8O5:      .77r    Lr7       .7EZk;     L77     .Y7r   irLY  JNMMF:    
//               LBBj
//
// Apworks Application Development Framework
// Copyright (C) 2009-2017 by daxnet.
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//    http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ==================================================================================================================

using System;
using System.Collections.Generic;

namespace Apworks.Messaging
{
    /// <summary>
    /// Represents that the implemented classes are message consumers that will use
    /// its internal message subscriber to subscribe the message bus and take specific
    /// actions when there is any incoming messages.
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    public interface IMessageConsumer<TMessageSubscriber> : IDisposable
        where TMessageSubscriber : IMessageSubscriber
    {
        /// <summary>
        /// Gets the instance of <see cref="IMessageSubscriber"/> which subscribes
        /// to the message bus and notifies events when there is any incoming messages.
        /// </summary>
        TMessageSubscriber Subscriber { get; }

        /// <summary>
        /// Gets the message handler manager which manages all the instances of the registered
        /// message handlers. Also provides the message handler instances to the current
        /// message consumer.
        /// </summary>
        /// <value>
        /// The message handler manager.
        /// </value>
        IMessageHandlerExecutionContext MessageHandlerManager { get; }

        /// <summary>
        /// Start consume the messages by using the message handlers.
        /// </summary>
        void Consume();
    }
}
