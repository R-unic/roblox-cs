﻿namespace RobloxCS.Luau
{
    public class ParameterList : Statement
    {
        public List<Parameter> Parameters { get; }

        public ParameterList(List<Parameter> parameters)
        {
            Parameters = parameters;
            AddChildren(Parameters);
        }

        public override void Render(LuauWriter luau)
        {
            luau.Write('(');
            luau.WriteNodesCommaSeparated(Parameters);
            luau.Write(')');
        }
    }
}