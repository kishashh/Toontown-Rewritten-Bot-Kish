﻿using System.Collections.Generic;
using WindowsInput;

namespace ToonTown_Rewritten_Bot.Models
{
    public class GolfActionCommand
    {
        public string Action { get; set; }
        public string Command { get; set; }
        public int Duration { get; set; }  // Duration in milliseconds
    }

    public class GolfActionKeys
    {
        public Dictionary<string, VirtualKeyCode> ActionKeyMap { get; private set; }

        public GolfActionKeys()
        {
            ActionKeyMap = new Dictionary<string, VirtualKeyCode>
            {
                { "SWING POWER", VirtualKeyCode.SPACE },
                { "TURN LEFT", VirtualKeyCode.VK_A },
                { "TURN RIGHT", VirtualKeyCode.VK_D },
                { "MOVE TO LEFT TEE SPOT", VirtualKeyCode.VK_A },
                { "MOVE TO RIGHT TEE SPOT", VirtualKeyCode.VK_D },
            };
        }

        // This method might throw an exception if the action is not found, consider using TryGetValue instead in your logic if you want to avoid exceptions.
        public VirtualKeyCode GetKeyCode(string action)
        {
            if (ActionKeyMap.TryGetValue(action, out var keyCode))
            {
                return keyCode;
            }
            else
            {
                throw new KeyNotFoundException($"No key code found for action: {action}");
            }
        }
    }
}