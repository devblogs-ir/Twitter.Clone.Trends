﻿using Twitter.Clone.Trends.Repositories;

namespace Twitter.Clone.Trends.TrendsPipeline;

public class TrendsGlobal(Action<HashtagRepository> next) : BasePipe(next)
{
    public override void Handle(HashtagRepository context)
    {

    }
}
