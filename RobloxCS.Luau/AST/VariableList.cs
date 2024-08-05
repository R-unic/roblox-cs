﻿namespace RobloxCS.Luau
{
    public class VariableList : Statement
    {
        public List<Variable> Variables { get; }

        public VariableList(List<Variable> variables)
        {
            Variables = variables;
            AddChildren(Variables);
        }

        public override void Render(LuauWriter luau)
        {
            foreach (var variable in Variables)
            {
                variable.Render(luau);
            }
        }
    }
}