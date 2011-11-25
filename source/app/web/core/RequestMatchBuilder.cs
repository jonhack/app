﻿namespace app.web.core
{
  public class RequestMatchBuilder : IBuildRequestMatchers
  {
    public RequestMatch made_for<Request>()
    {
      return x => x.request_name == typeof(Request).Name;
    }
  }
}