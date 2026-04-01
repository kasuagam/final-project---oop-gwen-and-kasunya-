using System;

public class InvalidDataException : Exception
{
	public InvalidDataException() { }

    public InvalidDataException(string message) : base(message) { }
}

public class OverCapacityException : Exception
{
    public OverCapacityException() { }

    public OverCapacityException(string message) : base(message) { }
}


public class EmptyStructureException : Exception
{
    public EmptyStructureException() { }

    public EmptyStructureException(string message) : base(message) { }
}

