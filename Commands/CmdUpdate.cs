/*
	Copyright 2010 MCSharp team (Modified for use with MCZall/MCLawl/MCForge)
	
	Dual-licensed under the	Educational Community License, Version 2.0 and
	the GNU General Public License, Version 3 (the "Licenses"); you may
	not use this file except in compliance with the Licenses. You may
	obtain a copy of the Licenses at
	
	http://www.osedu.org/licenses/ECL-2.0
	http://www.gnu.org/licenses/gpl-3.0.html
	
	Unless required by applicable law or agreed to in writing,
	software distributed under the Licenses are distributed on an "AS IS"
	BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
	or implied. See the Licenses for the specific language governing
	permissions and limitations under the Licenses.
*/
using System;
using System.Net;
using System.Threading;

namespace MCForge
{
    public class CmdUpdate : Command
    {
        public override string name { get { return "update"; } }
        public override string shortcut { get { return ""; } }
        public override string type { get { return "information"; } }
        public override bool museumUsable { get { return true; } }
        public override LevelPermission defaultRank { get { return LevelPermission.AdvBuilder; } }
        public CmdUpdate() { }

        public override void Use(Player p, string message)
        {
            if (p == null || p.group.Permission > LevelPermission.AdvBuilder) MCForge_.Gui.Program.UpdateCheck(false, p);
            else Player.SendMessage(p, "Ask an Operator to do it!");
        }
        public override void Help(Player p)
        {
            Player.SendMessage(p, "/update - Updates the server if it's out of date");
        }
    }
}