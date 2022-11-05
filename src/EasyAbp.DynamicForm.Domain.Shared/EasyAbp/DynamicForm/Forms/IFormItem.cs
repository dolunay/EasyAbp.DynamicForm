﻿using EasyAbp.DynamicForm.FormTemplates;
using EasyAbp.DynamicForm.Shared;
using JetBrains.Annotations;

namespace EasyAbp.DynamicForm.Forms;

public interface IFormItem
{
    [NotNull]
    string Name { get; }

    FormItemType Type { get; }

    [CanBeNull]
    string Value { get; }
}