# Add EditorConfig
    1. Show Extension: ShowEditorConfig Language Service
    2. Add New Item > editorconfig File (.Net)
    3. difference between default and dotnet
    4. show in VSCode
    5. Show how format document use the editorconfig (indent_size = 20)

# Show how to install the analyser
    1. Install nuget Packages (StyleCop)
    2. Project settings > Code Analysis > install
    3. Show the link (What are the benefits of source code analyzers?)
    4. Show Analyze menue (Configure fot Solution is deprecated!)
    5. Project > [right click] > analyze and code cleanup > Run code analysis
    6. Show Error list
    7. differents between [IDE, SA, CA]
    8. Setup Background analysis scope
    9. Use .editorconfig compatibility mode

# show rules and refactoring
    1. go to: Error List
    2. Sort by: Code
    3. show by grouping
    4. show refactoring and fix issues for Solution: SA1137, (SA1121+IDE0049), IDE 0055
    5. show generate doc
    6. empty return value
    7. set on error
    8. remove return value and setup rule
    9. Product Controller remove logger
    10. generate fields *add to editor
    11. null validation

## underscore
dotnet_naming_rule.instance_fields_should_be_camel_case.severity = suggestion
dotnet_naming_rule.instance_fields_should_be_camel_case.symbols = instance_fields
dotnet_naming_rule.instance_fields_should_be_camel_case.style = instance_field_style
 
dotnet_naming_symbols.instance_fields.applicable_kinds = field
 
dotnet_naming_style.instance_field_style.capitalization = camel_case
dotnet_naming_style.instance_field_style.required_prefix = _

## null validation
dotnet_diagnostic.CA1062.severity = warning
dotnet_code_quality.CA1062.null_check_validation_method = NRTGuards.Guard.Against.Null`
